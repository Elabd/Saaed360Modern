using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LocationDocumentContainerView
{
    public long LocationDocumentId { get; set; }

    public string LocationDocumentDescription { get; set; } = null!;

    public long LocationId { get; set; }

    public long DocumentId { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public string? DocumentInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
