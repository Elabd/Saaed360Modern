using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OfficerInjury
{
    public long PersonInjuryId { get; set; }

    public int OfficerActivityId { get; set; }

    public int OfficerMeansOfAttackId { get; set; }

    public int OfficerAssignmentId { get; set; }

    public int OfficerInjuryListId { get; set; }

    public bool UsedBodyAmor { get; set; }

    public bool UseWeapon { get; set; }

    public bool AwareOfWeapon { get; set; }

    public bool OffenderFiredWeapon { get; set; }

    public bool OfficerFiredWeapon { get; set; }

    public int YearsOfExp { get; set; }

    public virtual OfficerActivityDim OfficerActivity { get; set; } = null!;

    public virtual OfficerAssignmentDim OfficerAssignment { get; set; } = null!;

    public virtual OfficerInjuryListDim OfficerInjuryList { get; set; } = null!;

    public virtual OfficerMeansOfAttackDim OfficerMeansOfAttack { get; set; } = null!;

    public virtual PersonInjury PersonInjury { get; set; } = null!;
}
