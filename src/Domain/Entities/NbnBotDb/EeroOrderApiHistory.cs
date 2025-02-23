using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class EeroOrderApiHistory
{
    public long Id { get; set; }

    public long? EeroOrderId { get; set; }

    public string? EeroSerial { get; set; }

    public string? EeroId { get; set; }

    public string? ApiRequest { get; set; }

    public string? ApiResponse { get; set; }

    public string? LogComments { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
