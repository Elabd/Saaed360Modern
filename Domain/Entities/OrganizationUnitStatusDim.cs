using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationUnitStatusDim
{
    public int OrganizationUnitStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<OrganizationUnitLog> OrganizationUnitLogs { get; set; } = new List<OrganizationUnitLog>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
