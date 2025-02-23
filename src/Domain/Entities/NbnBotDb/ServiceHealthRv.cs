using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class ServiceHealthRv
{
    public long Id { get; set; }

    public long ServiceHealthId { get; set; }

    public string? RvName { get; set; }

    public string? RvDescription { get; set; }

    public DateTime? RvCaptureDatetime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
