using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationJudicialOfficialView
{
    public long PersonId { get; set; }

    public string Description { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? PersonStatusCode { get; set; }

    public string? PersonStatusDescription { get; set; }

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

    public string? RowStatusDescription { get; set; }

    public string? JudicialOfficialBarStatusCode { get; set; }

    public string? JudicialOfficialBarStatusDescription { get; set; }

    public string? JudicialOfficialCategoryCode { get; set; }

    public string? JudicialOfficialCategoryDescription { get; set; }

    public string? JudicialOfficialPanelCode { get; set; }

    public string? JudicialOfficialPanelDescription { get; set; }

    public string? JudicialOfficialBarIdentification { get; set; }

    public string? IdentificationJurisdiction { get; set; }

    public string? JudicialOfficialRegIdentification { get; set; }

    public long OrganizationPersonId { get; set; }

    public string OrganizationPersonDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public string? PersonInvolvementDescription { get; set; }

    public string? OrganizationPersonnelCategoryCode { get; set; }

    public string? OrganizationPersonnelCategoryDescription { get; set; }

    public string? OrganizationPersonnelRoleCode { get; set; }

    public string? OrganizationPersonnelRoleDescription { get; set; }

    public bool? IsActive { get; set; }
}
