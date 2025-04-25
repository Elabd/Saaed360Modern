using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ContactView
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

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
