using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationPersonnelCategoryDim
{
    public int OrganizationPersonnelCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<OrganizationPerson> OrganizationPeople { get; set; } = new List<OrganizationPerson>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
