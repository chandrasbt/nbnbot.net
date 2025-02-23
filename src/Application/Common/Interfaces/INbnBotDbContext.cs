using NbnBotClean.Domain.Entities;
using NbnBotClean.Domain.Entities.NbnBotDb;

namespace NbnBotClean.Application.Common.Interfaces;

public interface INbnBotDbContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    DbSet<ServiceClass> ServiceClasses { get; set; }
}
