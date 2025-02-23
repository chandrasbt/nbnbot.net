using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class WsmCallbacksRaw
{
    public long Id { get; set; }

    public string? ClientIp { get; set; }

    public int? Status { get; set; }

    public long? UpdatedByUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? ErrorMessage { get; set; }

    public string? RawPayload { get; set; }
}
