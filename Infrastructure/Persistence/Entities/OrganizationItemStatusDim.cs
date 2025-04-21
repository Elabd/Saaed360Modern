using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationItemStatusDim
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<OrganizationItem> OrganizationItems { get; set; } = new List<OrganizationItem>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
