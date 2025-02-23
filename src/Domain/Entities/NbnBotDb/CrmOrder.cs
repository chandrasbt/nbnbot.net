using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class CrmOrder
{
    public long Id { get; set; }

    public long? CrmImportId { get; set; }

    public string? NewMtorderid { get; set; }

    public string? NewNbnlocid { get; set; }

    public string? NewOrdernumber { get; set; }

    public string? FvNewOrdertype { get; set; }

    public string? NewAppointmentdate { get; set; }

    public string? NewSitepostcode { get; set; }

    public string? NewDeliveryunitnumber { get; set; }

    public string? NewSitestreetnumber { get; set; }

    public string? NewSitestreetname { get; set; }

    public string? NewSiteaddresscountrycode { get; set; }

    public string? NewSitesuburb { get; set; }

    public string? NewNbnlongaddress { get; set; }

    public string? NewUtilibillaccountnumber { get; set; }

    public string? FvNewNbnserviceclass { get; set; }

    public string? FvNewNbnservicetype { get; set; }

    public string? SqServiceType { get; set; }

    public string? FvNewAccount { get; set; }

    public string? FvNewSitestreettype { get; set; }

    public string? FvNewSitestate { get; set; }

    public string? FvNewNbnnewtransfer { get; set; }

    public string? FvNewCsaid { get; set; }

    public string? FvNewNbnspeedtier { get; set; }

    public string? FvNewUbgroup { get; set; }

    public string? FvNewModemonorder { get; set; }

    public string? FvNewNewdevchargeapplies { get; set; }

    public short? CheckModemonorder { get; set; }

    public short? CheckNewdevchargeapplies { get; set; }

    public short? CheckAddress { get; set; }

    public short? CheckHfcSpeed { get; set; }

    public string? PlanId { get; set; }

    public string? CopperPairId { get; set; }

    public string? ReferenceId { get; set; }

    public string? PhoneNumber { get; set; }

    public short? Status { get; set; }

    public string? ServiceId { get; set; }

    public short? Resubmit { get; set; }

    public string? NoteTag { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? NewPreferredstartdate { get; set; }

    public short? CheckCoatUpgrade { get; set; }

    public string? NewMtordertypeid { get; set; }

    public string? NewNbnspeedtier { get; set; }

    public string? NewNbnservicetype { get; set; }

    public string? NewUseableip { get; set; }

    public string? NewEslatype { get; set; }

    public string? NewStaticip { get; set; }

    public string? NewMtproductid { get; set; }

    public string? NewProductnumber { get; set; }
}
