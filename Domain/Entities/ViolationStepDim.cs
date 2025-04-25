using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViolationStepDim
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<Violation> Violations { get; set; } = new List<Violation>();

    public virtual ICollection<ViolationsStep> ViolationsSteps { get; set; } = new List<ViolationsStep>();

    public virtual ICollection<ViolationsStepsRole> ViolationsStepsRoles { get; set; } = new List<ViolationsStepsRole>();
}
