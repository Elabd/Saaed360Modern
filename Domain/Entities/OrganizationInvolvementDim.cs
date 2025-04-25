using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationInvolvementDim
{
    public int OrganizationInvolvementId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ActivityOrganization> ActivityOrganizations { get; set; } = new List<ActivityOrganization>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
