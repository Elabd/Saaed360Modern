using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViolationsStep
{
    public long Id { get; set; }

    public long? ViolationId { get; set; }

    public long? ViolationStepDimId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Violation? Violation { get; set; }

    public virtual ViolationStepDim? ViolationStepDim { get; set; }
}
