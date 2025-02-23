using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class NbnPlanSpeed
{
    public int Id { get; set; }

    public string? MtProductItemTitle { get; set; }

    public string? MtProductItemGuid { get; set; }

    public string? UbPlanTitle { get; set; }

    public string? UbPlanGuid { get; set; }

    public int? UbId { get; set; }

    public string? ServiceTypeTechnology { get; set; }

    public string? TelcoBrand { get; set; }

    public int? DownloadSpeedMbps { get; set; }

    public int? UploadSpeedMbps { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
