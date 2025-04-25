using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Dissemination
{
    public long ActivityId { get; set; }

    public int? DisseminationMethodId { get; set; }

    public DateTime? DissemintatedDateTime { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual DisseminationMethodDim? DisseminationMethod { get; set; }
}
