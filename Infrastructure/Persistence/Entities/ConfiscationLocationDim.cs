using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ConfiscationLocationDim
{
    public int ConfiscationLocationId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<DriverDatum> DriverData { get; set; } = new List<DriverDatum>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
