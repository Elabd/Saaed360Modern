using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonRaceDim
{
    public int PersonRaceId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public string? LongDescription { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonPhysicalDetail> PersonPhysicalDetails { get; set; } = new List<PersonPhysicalDetail>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
