using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationJudicialOfficialGuidView
{
    public Guid PersonGuid { get; set; }

    public string Description { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? PersonStatusCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Moniker { get; set; }

    public string? Suffix { get; set; }

    public string? Prefix { get; set; }

    public int? PersonCategoryId { get; set; }

    public string? RowStatusCode { get; set; }

    public string? JudicialOfficialBarStatusCode { get; set; }

    public string? JudicialOfficialCategoryCode { get; set; }

    public string? JudicialOfficialPanelCode { get; set; }

    public string? JudicialOfficialBarIdentification { get; set; }

    public string? IdentificationJurisdiction { get; set; }

    public string? JudicialOfficialRegIdentification { get; set; }

    public Guid OrganizationPersonGuid { get; set; }

    public string OrganizationPersonDescription { get; set; } = null!;

    public Guid OrganizationGuid { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public string? OrganizationPersonnelCategoryCode { get; set; }

    public string? OrganizationPersonnelRoleCode { get; set; }

    public bool? IsActive { get; set; }
}
