using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RequestStepDim
{
    public int RequestStepId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }

    public virtual ICollection<EscortRequestStep> EscortRequestSteps { get; set; } = new List<EscortRequestStep>();
}
