using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ChargeDegreeDim
{
    public int ChargeDegreeId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Charge> Charges { get; set; } = new List<Charge>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
