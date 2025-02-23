using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class Migration
{
    public long Id { get; set; }

    public string Migration1 { get; set; } = null!;

    public int Batch { get; set; }
}
