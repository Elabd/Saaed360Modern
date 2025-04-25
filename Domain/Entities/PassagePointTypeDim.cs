using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PassagePointTypeDim
{
    public int PassagePointTypeId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Offense> OffenseEntryPassagePoints { get; set; } = new List<Offense>();

    public virtual ICollection<Offense> OffenseExitPassagePoints { get; set; } = new List<Offense>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
