using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityDocumentContainerView
{
    public long ActivityDocumentId { get; set; }

    public string ActivityDocumentDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public long DocumentId { get; set; }

    public string? SourceName { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public string? DocumentInvolvementDescription { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
