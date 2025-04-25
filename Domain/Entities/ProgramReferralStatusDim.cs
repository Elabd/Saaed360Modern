using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ProgramReferralStatusDim
{
    public int ProgramReferralStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime? VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ProgramParticipation> ProgramParticipations { get; set; } = new List<ProgramParticipation>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
