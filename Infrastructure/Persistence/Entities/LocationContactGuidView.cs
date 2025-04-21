using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LocationContactGuidView
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

    public Guid LocationContactGuid { get; set; }

    public string LocationContactDescription { get; set; } = null!;

    public Guid LocationGuid { get; set; }

    public string? ContactInvolvementCode { get; set; }
}
