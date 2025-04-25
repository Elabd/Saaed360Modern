using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EthnicityDim
{
    public int EthnicityId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public string? LongDescription { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonVitalStatistic> PersonVitalStatistics { get; set; } = new List<PersonVitalStatistic>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SubjectOrganization> SubjectOrganizations { get; set; } = new List<SubjectOrganization>();

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
