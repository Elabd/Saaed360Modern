using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationAssociationCategoryDim
{
    public int OrganizationAssociationCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<OrganizationAssociation> OrganizationAssociations { get; set; } = new List<OrganizationAssociation>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
