using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CriminalInvolvementDim
{
    public int CriminalInvolvementId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SubjectOrganization> SubjectOrganizations { get; set; } = new List<SubjectOrganization>();

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
