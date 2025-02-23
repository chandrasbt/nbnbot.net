using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class Config
{
    public long Id { get; set; }

    public string? Category { get; set; }

    public string? Subcategory { get; set; }

    public string? ConfigKey { get; set; }

    public string? ConfigValue { get; set; }

    public string? ConfigText { get; set; }

    public long? UpdatedByUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
