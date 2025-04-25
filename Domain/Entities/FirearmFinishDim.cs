using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FirearmFinishDim
{
    public int FirearmFinishId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Firearm> Firearms { get; set; } = new List<Firearm>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
