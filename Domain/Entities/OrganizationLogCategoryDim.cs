using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationLogCategoryDim
{
    public int OrganizationLogCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<OrganizationUnitLog> OrganizationUnitLogs { get; set; } = new List<OrganizationUnitLog>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
