using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class RoleHasPermission
{
    public long PermissionId { get; set; }

    public long RoleId { get; set; }
}
