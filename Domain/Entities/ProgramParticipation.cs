using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ProgramParticipation
{
    public long ActivityId { get; set; }

    public bool ProgramPubliclyRunIndicator { get; set; }

    public bool ProgramRepatedIndicator { get; set; }

    public int ProgramReferralStatusId { get; set; }

    public int ProgramStatusId { get; set; }

    public int ProgramId { get; set; }

    public DateTime ReferredDateTime { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual ProgramDim Program { get; set; } = null!;

    public virtual ProgramReferralStatusDim ProgramReferralStatus { get; set; } = null!;

    public virtual ProgramStatusDim ProgramStatus { get; set; } = null!;
}
