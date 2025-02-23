using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class Summary
{
    public long Id { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime SummaryDate { get; set; }

    public int? Submitted { get; set; }

    public int? Provisioned { get; set; }

    public int? Processing { get; set; }

    public int? Active { get; set; }

    public int? Archived { get; set; }

    public int? Failed { get; set; }

    public int? Errored { get; set; }

    public int? Withdrawn { get; set; }
}
