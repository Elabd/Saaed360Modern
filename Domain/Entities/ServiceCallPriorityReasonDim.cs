using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceCallPriorityReasonDim
{
    public int ServiceCallPriorityReasonId { get; set; }

    public string? Code { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public int? ServiceCallPriorityId { get; set; }

    public virtual ServiceCallPriorityDim? ServiceCallPriority { get; set; }
}

