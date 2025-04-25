using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationAssociationView
{
    public long OrganizationAssociationId { get; set; }

    public string OrganizationAssociationDescription { get; set; } = null!;

    public long OrganizationRelatedId { get; set; }

    public long OrganizationId { get; set; }

    public string? OrganizationAssociationCategoryCode { get; set; }

    public string? OrganizationAssociationCategoryDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
