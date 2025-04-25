using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReleaseReasonDim
{
    public int ReleaseReasonId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Release> Releases { get; set; } = new List<Release>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
