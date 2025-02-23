using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class ModelHasPermission
{
    public long PermissionId { get; set; }

    public string ModelType { get; set; } = null!;

    public long ModelId { get; set; }
}
