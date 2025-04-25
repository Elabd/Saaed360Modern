using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CaseExhibitStatusDim
{
    public int CaseExhibitStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<CaseExhibit> CaseExhibits { get; set; } = new List<CaseExhibit>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
