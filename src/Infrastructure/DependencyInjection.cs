using NbnBotClean.Application.Common.Interfaces;
using NbnBotClean.Domain.Constants;
using NbnBotClean.Infrastructure.Data;
using NbnBotClean.Infrastructure.Data.Interceptors;
using NbnBotClean.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static void AddInfrastructureServices(this IHostApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("NbnBotCleanDb");
        Guard.Against.Null(connectionString, message: "Connection string 'NbnBotCleanDb' not found.");
        var connectionStringNbnBot = builder.Configuration.GetConnectionString("NbnBotDb");
        Guard.Against.Null(connectionString, message: "Connection string 'NbnBotDb' not found.");

        builder.Services.AddScoped<ISaveChangesInterceptor, AuditableEntityInterceptor>();
        builder.Services.AddScoped<ISaveChangesInterceptor, DispatchDomainEventsInterceptor>();

        builder.Services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());
            options.UseSqlServer(connectionString);
        });
        builder.Services.AddDbContext<NbnBotDbContext>((sp, options) =>
        {
            options.ConfigureWarnings(wb => wb.Ignore(RelationalEventId.PendingModelChangesWarning));
			options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());
            options.UseSqlServer(connectionStringNbnBot);
        });


        builder.Services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
        builder.Services.AddScoped<INbnBotDbContext>(provider => provider.GetRequiredService<NbnBotDbContext>());

        builder.Services.AddScoped<ApplicationDbContextInitialiser>();
        builder.Services.AddScoped<NbnBotDbContextInitialiser>();
        
        builder.Services.AddAuthentication()
            .AddBearerToken(IdentityConstants.BearerScheme);

        builder.Services.AddAuthorizationBuilder();

        builder.Services
            .AddIdentityCore<ApplicationUser>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddApiEndpoints();

        builder.Services.AddSingleton(TimeProvider.System);
        builder.Services.AddTransient<IIdentityService, IdentityService>();

        builder.Services.AddAuthorization(options =>
            options.AddPolicy(Policies.CanPurge, policy => policy.RequireRole(Roles.Administrator)));
    }
}
