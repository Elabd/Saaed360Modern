using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class WarrantLevelDim
{
    public int WarrantLevelId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<Warrant> Warrants { get; set; } = new List<Warrant>();
}
