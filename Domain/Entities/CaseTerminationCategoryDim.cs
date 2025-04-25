using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CaseTerminationCategoryDim
{
    public int CaseTerminationCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Case> Cases { get; set; } = new List<Case>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
