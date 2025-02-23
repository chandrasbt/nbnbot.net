using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class TransactionLog
{
    public long Id { get; set; }

    public string? TransactionId { get; set; }

    public string? Status { get; set; }

    public string? Request { get; set; }

    public DateTime? DateUpdated { get; set; }

    public string? LineSize { get; set; }

    public string? PlanType { get; set; }

    public string? Username { get; set; }

    public string? CarrierId { get; set; }

    public string? Name { get; set; }

    public string? Domain { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
