using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CounselingCategoryDim
{
    public int CounselingCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Counseling> Counselings { get; set; } = new List<Counseling>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
