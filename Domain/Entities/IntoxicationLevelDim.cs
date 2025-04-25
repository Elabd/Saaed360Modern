using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IntoxicationLevelDim
{
    public int IntoxicationLevelId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonIntoxication> PersonIntoxications { get; set; } = new List<PersonIntoxication>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
