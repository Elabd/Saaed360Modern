using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LicensePlateListSourceDim
{
    public int LicensePlateListSourceId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool InEmirates { get; set; }

    public virtual ICollection<DriverDatum> DriverData { get; set; } = new List<DriverDatum>();

    public virtual ICollection<LicensePlate> LicensePlates { get; set; } = new List<LicensePlate>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<RspDriverDatum> RspDriverData { get; set; } = new List<RspDriverDatum>();
}

