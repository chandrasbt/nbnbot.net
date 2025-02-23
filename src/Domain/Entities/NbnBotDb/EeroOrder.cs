using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class EeroOrder
{
    public long Id { get; set; }

    public long? CrmImportId { get; set; }

    public string? NewMtproductid { get; set; }

    public string? NewProductnumber { get; set; }

    public string? NewAccount { get; set; }

    public string? NewNbnserviceclass { get; set; }

    public string? NewNbnlocid { get; set; }

    public string? NewName { get; set; }

    public string? NewMtproductcategory { get; set; }

    public string? NewMtproductitem { get; set; }

    public string? NewUbplan { get; set; }

    public string? NewUbgroup { get; set; }

    public string? NewServicetype { get; set; }

    public string? NewOriginatingmtorder { get; set; }

    public string? NewEerostatus { get; set; }

    public string? NewSenttoeerodate { get; set; }

    public string? NewSerialnumber { get; set; }

    public string? NewUtilibillaccountnumber { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FvNewNbnserviceclass { get; set; }

    public string? FvNewUbgroup { get; set; }

    public string? FvNewAccount { get; set; }

    public string? FvNewOriginatingmtorder { get; set; }

    public string? FvNewServicetype { get; set; }

    public string? FvNewMtproductitem { get; set; }

    public string? FvNewMtproductcategory { get; set; }

    public short? Resubmit { get; set; }

    public string? NoteTag { get; set; }

    public string? UpdatedBy { get; set; }

    public string? EeroId { get; set; }

    public string? CallCounter { get; set; }

    public short? IsArchived { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }
}
