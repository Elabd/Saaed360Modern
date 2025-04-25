using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsUserControlDim
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public virtual ICollection<EsStep> EsSteps { get; set; } = new List<EsStep>();
}
