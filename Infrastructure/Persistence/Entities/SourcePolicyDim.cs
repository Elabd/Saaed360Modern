using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SourcePolicyDim
{
    public int SourcePolicyId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<Source> Sources { get; set; } = new List<Source>();
}
