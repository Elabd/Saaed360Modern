using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class WarrantExtraditionLimitationDim
{
    public int WarrantExtraditionLimitationId { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<Warrant> Warrants { get; set; } = new List<Warrant>();
}
