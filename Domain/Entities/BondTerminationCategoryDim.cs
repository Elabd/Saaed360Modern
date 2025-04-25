using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BondTerminationCategoryDim
{
    public int BondTerminationCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Bond> Bonds { get; set; } = new List<Bond>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
