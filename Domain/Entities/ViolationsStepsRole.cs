using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViolationsStepsRole
{
    public int Id { get; set; }

    public long? ViolationStepDimId { get; set; }

    public Guid? RoleId { get; set; }

    public DateTime? CreationDate { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual AspnetRole? Role { get; set; }

    public virtual ViolationStepDim? ViolationStepDim { get; set; }
}
