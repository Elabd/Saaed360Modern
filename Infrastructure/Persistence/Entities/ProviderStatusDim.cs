using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ProviderStatusDim
{
    public int ProviderStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<Provider> Providers { get; set; } = new List<Provider>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
