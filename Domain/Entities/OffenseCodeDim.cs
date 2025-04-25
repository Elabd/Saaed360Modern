using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OffenseCodeDim
{
    public int OffenseCodeId { get; set; }

    public string? Category { get; set; }

    public string? Description { get; set; }

    public string? OffenseLevel { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public string? EndNote { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Offense> Offenses { get; set; } = new List<Offense>();

    public virtual ICollection<RequestOffense> RequestOffenses { get; set; } = new List<RequestOffense>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<TipLeadOffense> TipLeadOffenses { get; set; } = new List<TipLeadOffense>();
}
