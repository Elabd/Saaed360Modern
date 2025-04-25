using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SupervisionCustodyStatusDim
{
    public int SupervisionCustodyStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Correction> Corrections { get; set; } = new List<Correction>();

    public virtual ICollection<Parole> Paroles { get; set; } = new List<Parole>();

    public virtual ICollection<Probation> Probations { get; set; } = new List<Probation>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<Supervision> Supervisions { get; set; } = new List<Supervision>();
}
