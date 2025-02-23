using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class ServiceHealthDatum
{
    public long Id { get; set; }

    public long ServiceHealthId { get; set; }

    public string? MetricName { get; set; }

    public string? MetricType { get; set; }

    public string? ParamName { get; set; }

    public string? ParamCode { get; set; }

    public string? ParamStatus { get; set; }

    public string? ParamUnit { get; set; }

    public string? ParamValue { get; set; }

    public DateTime? CaptureDatetime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
