using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DriverStatusDim
{
    public int DriverStatusId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool IsDefaultForReportConstruction { get; set; }

    public virtual ICollection<DriverDatum> DriverData { get; set; } = new List<DriverDatum>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
