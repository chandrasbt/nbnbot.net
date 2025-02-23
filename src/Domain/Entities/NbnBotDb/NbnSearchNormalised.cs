using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class NbnSearchNormalised
{
    public long Id { get; set; }

    public long? UploadId { get; set; }

    public string? Username { get; set; }

    public int? UserId { get; set; }

    public int? Status { get; set; }

    public string? ServiceId { get; set; }

    public string? ServiceStatus { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? ApiResponse { get; set; }
}
