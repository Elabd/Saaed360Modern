using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationContactView
{
    public long ContactId { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? ContactCategoryCode { get; set; }

    public string? ContactCategoryDescription { get; set; }

    public string? ContactName { get; set; }

    public string ContactInformation { get; set; } = null!;

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public long OrganizationContactId { get; set; }

    public string OrganizationContactDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public string? ContactInvolvementCode { get; set; }

    public string? ContactInvolvementDescription { get; set; }
}
