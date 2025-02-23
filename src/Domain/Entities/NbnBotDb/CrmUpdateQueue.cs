using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class CrmUpdateQueue
{
    public long Id { get; set; }

    public string? DbOperation { get; set; }

    public string? EntityName { get; set; }

    public string? EntityReferenceId { get; set; }

    public string? CrmData { get; set; }

    public int? Status { get; set; }

    public string? ErrorMsg { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
