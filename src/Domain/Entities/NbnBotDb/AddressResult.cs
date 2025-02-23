using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class AddressResult
{
    public long Id { get; set; }

    public long? RawId { get; set; }

    public string? DirectoryId { get; set; }

    public string? TransactionId { get; set; }

    public string? FibreAddressRecord { get; set; }

    public string? AddressLong { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
