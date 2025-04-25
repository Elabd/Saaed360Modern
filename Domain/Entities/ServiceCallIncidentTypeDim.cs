using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceCallIncidentTypeDim
{
    public int ServiceCallIncidentTypeId { get; set; }

    public string? Description { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public int? TfmId { get; set; }

    public long OrganizationId { get; set; }

    public virtual ICollection<IncidentCategoryTypeAssociation> IncidentCategoryTypeAssociations { get; set; } = new List<IncidentCategoryTypeAssociation>();

    public virtual Organization Organization { get; set; } = null!;

    public virtual ICollection<ServiceCall> ServiceCalls { get; set; } = new List<ServiceCall>();
}

