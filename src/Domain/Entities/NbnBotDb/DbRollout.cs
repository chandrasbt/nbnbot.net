using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class DbRollout
{
    public long Id { get; set; }

    public int? VersionNumber { get; set; }

    public short? Success { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
