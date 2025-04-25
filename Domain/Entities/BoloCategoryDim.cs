using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BoloCategoryDim
{
    public int BoloCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Bolo> Bolos { get; set; } = new List<Bolo>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
