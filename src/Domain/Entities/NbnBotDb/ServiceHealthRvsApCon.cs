using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class ServiceHealthRvsApCon
{
    public long Id { get; set; }

    public long ServiceHealthRvId { get; set; }

    public string? RvAcName { get; set; }

    public string? RvAcDescription { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
