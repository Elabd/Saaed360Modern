using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LicenseCategoryDim
{
    public int LicenseCategoryId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<DriverDatum> DriverData { get; set; } = new List<DriverDatum>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<RspDriverDatum> RspDriverData { get; set; } = new List<RspDriverDatum>();

    public virtual ICollection<VehicleCategoryToLicenseCategoryMap> VehicleCategoryToLicenseCategoryMaps { get; set; } = new List<VehicleCategoryToLicenseCategoryMap>();
}
