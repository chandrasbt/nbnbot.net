using System;
using System.Collections.Generic;

namespace NbnBotClean.Domain.Entities.NbnBotDb;

public partial class SqResult
{
    public long Id { get; set; }

    public long? RawId { get; set; }

    public string? DirectoryId { get; set; }

    public string? TransactionId { get; set; }

    public string? Result { get; set; }

    public string? ServiceType { get; set; }

    public string? ServiceClass { get; set; }

    public string? DataPort { get; set; }

    public string? VoicePort { get; set; }

    public string? NbnportRecord { get; set; }

    public string? Csa { get; set; }

    public string? Cvcid { get; set; }

    public string? Zone { get; set; }

    public string? VoiceCvcid { get; set; }

    public string? TrafficClass1 { get; set; }

    public string? TrafficClass2 { get; set; }

    public string? TrafficClass3 { get; set; }

    public string? TrafficClass4 { get; set; }

    public string? AvailableCtag { get; set; }

    public string? Stag { get; set; }

    public string? Ntdid { get; set; }

    public string? Battery { get; set; }

    public string? ConnectionType { get; set; }

    public string? DevelopmentCharge { get; set; }

    public string? CopperPairRecord { get; set; }

    public string? ActivationDate { get; set; }

    public string? CopperDisconnectionDate { get; set; }

    public string? NbnfeatureRecord { get; set; }

    public string? HfcselfInstall { get; set; }

    public string? BroadbandAddressRecord { get; set; }

    public string? AddressLong { get; set; }

    public string? AlternativeTechnology { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Nbncoatrecord { get; set; }
}
