using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LocationDocumentContainerGuidView
{
    public Guid LocationDocumentGuid { get; set; }

    public string LocationDocumentDescription { get; set; } = null!;

    public Guid LocationGuid { get; set; }

    public Guid DocumentGuid { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
