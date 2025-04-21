using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DispositionReasonDim
{
    public int DispositionReasonId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Disposition> Dispositions { get; set; } = new List<Disposition>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
