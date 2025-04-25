using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AreaInvolvementDim
{
    public int AreaInvolvementId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ActivityArea> ActivityAreas { get; set; } = new List<ActivityArea>();

    public virtual ICollection<LocationArea> LocationAreas { get; set; } = new List<LocationArea>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
