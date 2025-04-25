using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityMissingPersonGuidView
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

    public string? MissingPersonCategoryCode { get; set; }

    public string? MissingPersonCircumstanceCode { get; set; }

    public string? MissingPersonStatusCode { get; set; }

    public Guid DeclarationPersonGuid { get; set; }

    public Guid FoundLocationGuid { get; set; }

    public Guid LastSeenLocationGuid { get; set; }

    public DateTime? DeclarationDate { get; set; }

    public DateTime? LastSeenDate { get; set; }

    public DateTime? FoundDate { get; set; }

    public bool? InterestIndicator { get; set; }

    public bool? FoundIndicator { get; set; }

    public Guid ActivityPersonGuid { get; set; }

    public string ActivityPersonDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public string? PersonInvolvementCode { get; set; }
}
