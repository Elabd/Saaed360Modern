using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Request
{
    public long ActivityId { get; set; }

    public int RequestCategoryId { get; set; }

    public int PolicyId { get; set; }

    public int PriorityHighLowId { get; set; }

    public int InputMethodId { get; set; }

    public int ClassificationId { get; set; }

    public string? EGuardianReferenceNumber { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public string? TrackingNumber { get; set; }

    public string? VideoUri { get; set; }

    public string? Instruction { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual ClassificationDim Classification { get; set; } = null!;

    public virtual RequestInputMethodDim InputMethod { get; set; } = null!;

    public virtual PolicyDim Policy { get; set; } = null!;

    public virtual HighLowDim PriorityHighLow { get; set; } = null!;

    public virtual RequestCategoryDim RequestCategory { get; set; } = null!;
}
