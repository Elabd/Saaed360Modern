using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityEnforcementOfficialGuidView
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

    public string? EnforcementOfficialAsnCategoryCode { get; set; }

    public string? EnforcementOfficialCategoryCode { get; set; }

    public string EnforcementOfficialBadgeIdentification { get; set; } = null!;

    public string EnforcementOfficialPostLicenseIdent { get; set; } = null!;

    public string EnforcementOfficialUnit { get; set; } = null!;

    public Guid ActivityPersonGuid { get; set; }

    public string ActivityPersonDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public string? PersonInvolvementCode { get; set; }
}
