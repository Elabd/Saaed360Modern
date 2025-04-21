using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationPersonContainerView
{
    public long OrganizationPersonId { get; set; }

    public string OrganizationPersonDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long OrganizationId { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public string? PersonInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public string? OrganizationPersonnelCategoryCode { get; set; }

    public string? OrganizationPersonnelCategoryDescription { get; set; }

    public string? OrganizationPersonnelRoleCode { get; set; }

    public string? OrganizationPersonnelRoleDescription { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
