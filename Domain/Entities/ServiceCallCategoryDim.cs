using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceCallCategoryDim
{
    public int ServiceCallCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<IncidentCategoryTypeAssociation> IncidentCategoryTypeAssociations { get; set; } = new List<IncidentCategoryTypeAssociation>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<ServiceCall> ServiceCalls { get; set; } = new List<ServiceCall>();
}

