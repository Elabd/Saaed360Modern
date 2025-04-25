using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OfficerInjuryGuidView
{
    public Guid PersonInjuryGuid { get; set; }

    public string PersonInjuryDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? SourceName { get; set; }

    public string? PersonPhysicianCode { get; set; }

    public string? PersonInjuryLevelCode { get; set; }

    public string? PersonMoruaryCode { get; set; }

    public string? PersonTransportedByCode { get; set; }

    public string? PersonMedicalByCode { get; set; }

    public string? PersonInjuryListCode { get; set; }

    public string? PersonMedicationCode { get; set; }

    public DateTime? EmsarrivedDateTime { get; set; }

    public DateTime? EmsnotifiedDateTime { get; set; }

    public DateTime? PronouncedDateTime { get; set; }

    public bool? CoronerNotified { get; set; }

    public bool? KinNotified { get; set; }

    public bool? IsDead { get; set; }

    public bool? IsInjured { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public string? OfficerActivityCode { get; set; }

    public string? OfficerMeansOfAttackCode { get; set; }

    public string? OfficerAssignmentCode { get; set; }

    public string? OfficerInjuryListCode { get; set; }

    public bool UsedBodyAmor { get; set; }

    public bool UseWeapon { get; set; }

    public bool AwareOfWeapon { get; set; }

    public bool OffenderFiredWeapon { get; set; }

    public bool OfficerFiredWeapon { get; set; }

    public int YearsOfExp { get; set; }
}
