using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationCategoryDim
{
    public int OrganizationCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
