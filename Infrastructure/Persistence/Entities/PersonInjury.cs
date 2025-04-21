using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonInjury
{
    public long PersonInjuryId { get; set; }

    public Guid PersonInjuryGuid { get; set; }

    public string PersonInjuryDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public int? PersonPhysicianId { get; set; }

    public int? PersonInjuryLevelId { get; set; }

    public int? PersonMoruaryId { get; set; }

    public int? PersonTransportedById { get; set; }

    public int? PersonMedicalById { get; set; }

    public int? PersonInjuryListId { get; set; }

    public int? PersonMedicationId { get; set; }

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

    public int? RowStatusId { get; set; }

    public virtual OfficerInjury? OfficerInjury { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonInjuryLevelDim? PersonInjuryLevel { get; set; }

    public virtual PersonInjuryListDim? PersonInjuryList { get; set; }

    public virtual PersonMedicalByDim? PersonMedicalBy { get; set; }

    public virtual PersonMedicationDim? PersonMedication { get; set; }

    public virtual PersonMoruaryDim? PersonMoruary { get; set; }

    public virtual PersonPhysicianDim? PersonPhysician { get; set; }

    public virtual PersonTransportedByDim? PersonTransportedBy { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
