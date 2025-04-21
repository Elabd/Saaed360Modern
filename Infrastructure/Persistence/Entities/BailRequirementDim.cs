using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class BailRequirementDim
{
    public int BailRequirementId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Bail> Bails { get; set; } = new List<Bail>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
