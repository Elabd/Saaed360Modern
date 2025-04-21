using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VehicleCategoryToLicenseCategoryMap
{
    public int Id { get; set; }

    public int LicenseCategoryId { get; set; }

    public int VehicleCategoryId { get; set; }

    public virtual LicenseCategoryDim LicenseCategory { get; set; } = null!;

    public virtual VehicleCategoryDim VehicleCategory { get; set; } = null!;
}
