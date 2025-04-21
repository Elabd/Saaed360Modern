using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonContactGuidView
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

    public Guid PersonContactGuid { get; set; }

    public string PersonContactDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? ContactInvolvementCode { get; set; }
}
