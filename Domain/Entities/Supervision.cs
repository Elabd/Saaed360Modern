using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Supervision
{
    public long ActivityId { get; set; }

    public int SupervisionCategoryId { get; set; }

    public int SupervisionCustodyStatusId { get; set; }

    public bool SupervisionMandatoryIndicator { get; set; }

    public int SupervisionStatusId { get; set; }

    public int FacilityBedAssignmentId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual FacilityBedAssignmentDim FacilityBedAssignment { get; set; } = null!;

    public virtual SupervisionCategoryDim SupervisionCategory { get; set; } = null!;

    public virtual SupervisionCustodyStatusDim SupervisionCustodyStatus { get; set; } = null!;

    public virtual SupervisionStatusDim SupervisionStatus { get; set; } = null!;
}
