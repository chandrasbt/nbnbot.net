using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Reflection;
//using NbnBotClean.Application.Helpers;
using NbnBotClean.Domain.Constants;
using NbnBotClean.Domain.Entities;
using NbnBotClean.Domain.Entities.NbnBotDb;
using NbnBotClean.Infrastructure.Identity;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace NbnBotClean.Infrastructure.Data;

public static partial class InitialiserExtensions
{
    public static async Task InitialiseNbnBotDbDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var initialiser = scope.ServiceProvider.GetRequiredService<NbnBotDbContextInitialiser>();

        await initialiser.InitialiseAsync();

        await initialiser.SeedAsync();
    }
}

public class NbnBotDbContextInitialiser
{
    private readonly ILogger<NbnBotDbContextInitialiser> _logger;
    private readonly NbnBotDbContext _context;

    public NbnBotDbContextInitialiser(ILogger<NbnBotDbContextInitialiser> logger, NbnBotDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task InitialiseAsync()
    {
        try
        {
            await _context.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while initialising the database.");
            throw;
        }
    }

    public async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while seeding the database.");
            throw;
        }
    }

    public async Task TrySeedAsync()
    {
        // Default data
        // Seed, if necessary


        if (!_context.ServiceClasses.Any())
        {
            await ImportCsvDataAsync<ServiceClass>("ServiceClasses.csv");
        }
    }

    public async Task ImportCsvDataAsync<T>(string fileName) where T : class
    {
        var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Seed", fileName);

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HeaderValidated = null,
            IgnoreBlankLines = true,
            TrimOptions = TrimOptions.Trim,
            PrepareHeaderForMatch = args =>
            {
                return typeof(T).GetProperties()
                    .FirstOrDefault(p =>
                        p.GetCustomAttribute<ColumnAttribute>()?.Name
                            ?.Equals(args.Header, StringComparison.OrdinalIgnoreCase) == true)
                    ?.Name ?? args.Header;
            },
            MissingFieldFound = null,
            BadDataFound = context =>
            {
                _logger.LogError($"Bad data found: {context.RawRecord}");
            },
            ReadingExceptionOccurred = context =>
            {
                if (context.Exception is CsvHelper.TypeConversion.TypeConverterException)
                {
                    return false;
                }
                return true;
            }
        };
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, config);


        var records = csv.GetRecords<T>().ToList();

        // Set all DateTime and DateTimeOffset properties to current date
        var dateProperties = typeof(T).GetProperties()
            .Where(p => p.PropertyType == typeof(DateTime) ||
                        p.PropertyType == typeof(DateTime?) ||
                        p.PropertyType == typeof(DateTimeOffset) ||
                        p.PropertyType == typeof(DateTimeOffset?));

        foreach (var record in records)
        {
            foreach (var prop in dateProperties)
            {
                if (prop.PropertyType == typeof(DateTime) || prop.PropertyType == typeof(DateTime?))
                {
                    prop.SetValue(record, DateTime.Today);
                }
                else if (prop.PropertyType == typeof(DateTimeOffset) || prop.PropertyType == typeof(DateTimeOffset?))
                {
                    prop.SetValue(record, DateTimeOffset.Now);
                }
            }
        }

        await _context.BulkInsertAsync(records);
    }
}
