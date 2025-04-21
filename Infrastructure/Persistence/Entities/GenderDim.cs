using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GenderDim
{
    public int GenderId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<DriverDatum> DriverData { get; set; } = new List<DriverDatum>();

    public virtual ICollection<MobileUser> MobileUsers { get; set; } = new List<MobileUser>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<RspDriverDatum> RspDriverData { get; set; } = new List<RspDriverDatum>();
}
