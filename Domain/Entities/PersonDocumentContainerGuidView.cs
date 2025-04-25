using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonDocumentContainerGuidView
{
    public Guid PersonDocumentGuid { get; set; }

    public string PersonDocumentDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid DocumentGuid { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
