using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationJudicialOfficialContainerGuidView
{
    public Guid OrganizationPersonGuid { get; set; }

    public string OrganizationPersonDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid OrganizationGuid { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public string? OrganizationPersonnelCategoryCode { get; set; }

    public string? OrganizationPersonnelRoleCode { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
