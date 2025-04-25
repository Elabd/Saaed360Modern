using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CitationStatusDim
{
    public int CitationStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Citation> Citations { get; set; } = new List<Citation>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
