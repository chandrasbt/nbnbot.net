using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class WsmServiceId
{
    public long Id { get; set; }

    public string? ServiceId { get; set; }

    public long? UpdatedByUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
