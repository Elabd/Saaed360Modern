using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FacilityView
{
    public long OrganizationId { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? OrganizationCategoryCode { get; set; }

    public string? OrganizationCategoryDescription { get; set; }

    public string? OrganizationStatusCode { get; set; }

    public string? OrganizationStatusDescription { get; set; }

    public string? Name { get; set; }

    public string? DoingBusinessAs { get; set; }

    public string? Description { get; set; }

    public string? AbbreviationText { get; set; }

    public string? Imonumber { get; set; }

    public DateTime? EstablishedDateTime { get; set; }

    public DateTime? TerminationDateTime { get; set; }

    public bool? IncorporatedIndicator { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public string? FacilityCategoryCode { get; set; }

    public string? FacilityCategoryDescription { get; set; }

    public bool FacilityCommercialIndicator { get; set; }

    public int FacilityCapacity { get; set; }

    public bool FacilityJuvenileIndicator { get; set; }

    public string? FacilityMemberCategoryCode { get; set; }

    public string? FacilityMemberCategoryDescription { get; set; }

    public string? FacilitySecurityLevelCode { get; set; }

    public string? FacilitySecurityLevelDescription { get; set; }
}
