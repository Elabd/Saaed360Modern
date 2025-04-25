using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EducationStatusDim
{
    public int EducationStatusId { get; set; }

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<DriverDatum> DriverData { get; set; } = new List<DriverDatum>();

    public virtual ICollection<PersonEducation> PersonEducations { get; set; } = new List<PersonEducation>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
