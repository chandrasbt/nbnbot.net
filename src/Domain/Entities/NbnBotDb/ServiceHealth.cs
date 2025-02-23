using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class ServiceHealth
{
    public long Id { get; set; }

    public string? ServiceId { get; set; }

    public string? HealthId { get; set; }

    public int? Status { get; set; }

    public string? Connectivity { get; set; }

    public string? Performance { get; set; }

    public string? Stability { get; set; }

    public string? ResponseStatus { get; set; }

    public DateTime? ResponseDatetime { get; set; }

    public string? ShsJson { get; set; }

    public int? NormalisationStatus { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
