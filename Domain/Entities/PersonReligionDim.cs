using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonReligionDim
{
    public int PersonReligionId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonVitalStatistic> PersonVitalStatistics { get; set; } = new List<PersonVitalStatistic>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
