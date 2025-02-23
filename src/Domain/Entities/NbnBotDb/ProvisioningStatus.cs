using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class ProvisioningStatus
{
    public long Id { get; set; }

    public int? Status { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Color { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
