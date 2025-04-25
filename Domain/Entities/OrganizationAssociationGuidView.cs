using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationAssociationGuidView
{
    public Guid OrganizationAssociationGuid { get; set; }

    public string OrganizationAssociationDescription { get; set; } = null!;

    public Guid OrganizationRelatedGuid { get; set; }

    public Guid OrganizationGuid { get; set; }

    public string? OrganizationAssociationCategoryCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
