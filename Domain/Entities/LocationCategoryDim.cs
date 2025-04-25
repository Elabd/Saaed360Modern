using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationCategoryDim
{
    public int LocationCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
