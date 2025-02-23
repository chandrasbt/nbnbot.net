namespace NbnBotClean.Domain.Entities.NbnBotDb;

public class ServiceClass
{
    public long Id { get; set; }

    public int? ServiceClass1 { get; set; }

    public string? Technology { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? OrderTypes { get; set; }
}
