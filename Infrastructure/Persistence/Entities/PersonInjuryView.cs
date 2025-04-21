using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonInjuryView
{
    public long PersonInjuryId { get; set; }

    public string PersonInjuryDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public string? PersonPhysicianCode { get; set; }

    public string? PersonPhysicianDescription { get; set; }

    public string? PersonInjuryLevelCode { get; set; }

    public string? PersonInjuryLevelDescription { get; set; }

    public string? PersonMoruaryCode { get; set; }

    public string? PersonMoruaryDescription { get; set; }

    public string? PersonTransportedByCode { get; set; }

    public string? PersonTransportedByDescription { get; set; }

    public string? PersonMedicalByCode { get; set; }

    public string? PersonMedicalByDescription { get; set; }

    public string? PersonInjuryListCode { get; set; }

    public string? PersonInjuryListDescription { get; set; }

    public string? PersonMedicationCode { get; set; }

    public string? PersonMedicationDescription { get; set; }

    public DateTime? EmsarrivedDateTime { get; set; }

    public DateTime? EmsnotifiedDateTime { get; set; }

    public DateTime? PronouncedDateTime { get; set; }

    public bool? CoronerNotified { get; set; }

    public bool? KinNotified { get; set; }

    public bool? IsDead { get; set; }

    public bool? IsInjured { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
