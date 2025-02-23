using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class UploadUsername
{
    public long Id { get; set; }

    public string? Username { get; set; }

    public int? UserId { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
