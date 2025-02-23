using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class CrmImport
{
    public string? UploadedByUserEmail { get; set; }

    public long Id { get; set; }

    public string? FileName { get; set; }

    public string? StoragePath { get; set; }

    public string? FileNameOriginal { get; set; }

    public long? TotalRows { get; set; }

    public int? Status { get; set; }

    public string? Error { get; set; }

    public int? ValidationCount { get; set; }

    public int? GenerationCount { get; set; }

    public string? OutputFileName { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
