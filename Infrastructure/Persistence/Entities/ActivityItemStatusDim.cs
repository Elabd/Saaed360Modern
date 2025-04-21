using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityItemStatusDim
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? TypeName { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ActivityItemStatusLocation> ActivityItemStatusLocations { get; set; } = new List<ActivityItemStatusLocation>();

    public virtual ICollection<ActivityItem> ActivityItems { get; set; } = new List<ActivityItem>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
