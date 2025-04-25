using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ConfiscationStatusDim
{
    public int ConfiscationStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<DriverDatum> DriverData { get; set; } = new List<DriverDatum>();

    public virtual ICollection<DriverDataConfiscationLog> DriverDataConfiscationLogs { get; set; } = new List<DriverDataConfiscationLog>();
}
