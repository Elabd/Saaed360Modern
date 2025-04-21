using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EducationCategoryDim
{
    public int EducationCategoryId { get; set; }

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonEducation> PersonEducations { get; set; } = new List<PersonEducation>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
