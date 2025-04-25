using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityContactGuidView
{
    public Guid ContactGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? ContactCategoryCode { get; set; }

    public string? ContactName { get; set; }

    public string ContactInformation { get; set; } = null!;

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public Guid ActivityContactGuid { get; set; }

    public string ActivityContactDescription { get; set; } = null!;

    public string? ContactInvolvementCode { get; set; }

    public Guid ActivityGuid { get; set; }
}
