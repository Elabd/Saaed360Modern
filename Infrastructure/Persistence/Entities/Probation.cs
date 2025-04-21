using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Probation
{
    public long ActivityId { get; set; }

    public int SupervisionCustodyStatusId { get; set; }

    public int SupervisionStatusId { get; set; }

    public bool SupervisionMandatoryIndicator { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual SupervisionCustodyStatusDim SupervisionCustodyStatus { get; set; } = null!;

    public virtual SupervisionStatusDim SupervisionStatus { get; set; } = null!;
}
