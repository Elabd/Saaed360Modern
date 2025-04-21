using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityContactView
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

    public long ActivityContactId { get; set; }

    public string ActivityContactDescription { get; set; } = null!;

    public string? ContactInvolvementCode { get; set; }

    public string? ContactInvolvementDescription { get; set; }

    public long ActivityId { get; set; }
}
