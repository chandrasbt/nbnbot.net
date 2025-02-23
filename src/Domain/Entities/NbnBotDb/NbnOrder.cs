using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class NbnOrder
{
    public long Id { get; set; }

    public long? CrmOrderId { get; set; }

    public string? NewOrdernumber { get; set; }

    public string? NewMtorderid { get; set; }

    public int? FvNewNbnserviceclass { get; set; }

    public string? FvNewNbnspeedtier { get; set; }

    public string? ProductId { get; set; }

    public string? PlanId { get; set; }

    public string? VoicebandContinuity { get; set; }

    public string? Scope { get; set; }

    public string? ServiceId { get; set; }

    public string? Realm { get; set; }

    public string? OrderType { get; set; }

    public string? CustomerName { get; set; }

    public string? Phone { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? ServiceType { get; set; }

    public string? TrafficClass1 { get; set; }

    public string? DataPortNumber { get; set; }

    public string? VoicePortId1 { get; set; }

    public string? VoicePortId2 { get; set; }

    public string? CopperPairId { get; set; }

    public string? CarrierId { get; set; }

    public string? Battery { get; set; }

    public string? ServiceLevel { get; set; }

    public string? CentralSplitter { get; set; }

    public string? Ntdid { get; set; }

    public string? DirectoryId { get; set; }

    public string? CpedirectoryId { get; set; }

    public string? CpeplanId { get; set; }

    public string? NbncpeplanId { get; set; }

    public string? Nbncrd { get; set; }

    public string? VoipserviceId { get; set; }

    public string? LocationReference { get; set; }

    public string? Reference { get; set; }

    public string? Cadate { get; set; }

    public string? NewUtilibillaccountnumber { get; set; }

    public int? Status { get; set; }

    public string? TransactionState { get; set; }

    public string? TransactionId { get; set; }

    public long? CallbackId { get; set; }

    public string? AppointmentDate { get; set; }

    public string? BillingProviderId { get; set; }

    public int? ServiceRunCount { get; set; }

    public string? Faultstring { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? ScheduledAt { get; set; }

    public DateTime? SubmittedAt { get; set; }

    public DateTime? ProvisionedAt { get; set; }

    public DateTime? ResponseUpdatedAt { get; set; }

    public short? IsArchived { get; set; }

    public string? ArchivalReason { get; set; }

    public string? NoteTag { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? AlternativeTechnology { get; set; }

    public int? LatestServiceHealthId { get; set; }

    public string? ServiceHealthSignal { get; set; }

    public string? NewUseableip { get; set; }

    public string? NewEslatype { get; set; }

    public string? NewStaticip { get; set; }

    public string? NewMtproductid { get; set; }

    public string? NewProductnumber { get; set; }

    public string? NewNbnavc { get; set; }

    public string? NewNbnpri { get; set; }
}
