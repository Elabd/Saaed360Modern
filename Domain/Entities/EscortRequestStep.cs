using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EscortRequestStep
{
    public long EscortRequestStepId { get; set; }

    public long EscortId { get; set; }

    public int RequestStepId { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public long? EmployeeId { get; set; }

    public bool IsEmployeeAction { get; set; }

    public virtual Escort Escort { get; set; } = null!;

    public virtual RequestStepDim RequestStep { get; set; } = null!;
}
