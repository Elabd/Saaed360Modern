using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DriverLicenseCommericalClassDim
{
    public int DriverLicenseCommericalClassId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonDriverLicense> PersonDriverLicenses { get; set; } = new List<PersonDriverLicense>();

    public virtual RowStatusDim? RowStatus { get; set; }
}

