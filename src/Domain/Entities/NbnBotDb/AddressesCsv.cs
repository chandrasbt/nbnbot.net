using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class AddressesCsv
{
    public long Id { get; set; }

    public string? SourceName { get; set; }

    public int? ChargeType { get; set; }

    public int? Fnn { get; set; }

    public string? Type { get; set; }

    public string? Cost { get; set; }

    public string? Billed { get; set; }

    public string? TechnologyType { get; set; }

    public string? Fsa { get; set; }

    public string? Address { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public int? Postcode { get; set; }

    public string? LocationIds { get; set; }
}
