using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemInvolvementDim
{
    public int ItemInvolvementId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ActivityItem> ActivityItems { get; set; } = new List<ActivityItem>();

    public virtual ICollection<OrganizationItem> OrganizationItems { get; set; } = new List<OrganizationItem>();

    public virtual ICollection<PersonItem> PersonItems { get; set; } = new List<PersonItem>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
