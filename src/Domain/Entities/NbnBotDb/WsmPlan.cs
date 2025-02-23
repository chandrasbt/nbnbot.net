using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class WsmPlan
{
    public long Id { get; set; }

    public string? PlanId { get; set; }

    public string? ProductId { get; set; }

    public string? Technology { get; set; }

    public string? Mapping { get; set; }

    public string? LineSpeed { get; set; }

    public string? ServiceTypeOptionsetValue { get; set; }

    public string? SpeedTypeOptionsetValue { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
