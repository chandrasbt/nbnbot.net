using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class WsmCallback
{
    public long Id { get; set; }

    public string? WsmTransactionId { get; set; }

    public string? Status { get; set; }

    public long? RawCallbackId { get; set; }

    public string? AckTransactionId { get; set; }

    public long? UpdatedByUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
