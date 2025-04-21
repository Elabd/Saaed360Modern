using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonContactView
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

    public long PersonContactId { get; set; }

    public string PersonContactDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public string? ContactInvolvementCode { get; set; }

    public string? ContactInvolvementDescription { get; set; }
}
