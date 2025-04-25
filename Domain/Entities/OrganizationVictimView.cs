using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationVictimView
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

    public string? VictimCategoryCode { get; set; }

    public string? VictimCategoryDescription { get; set; }

    public string? VictimMeansOfAttackCode { get; set; }

    public string? VictimMeansOfAttackDescription { get; set; }

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
