using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonDocumentContainerView
{
    public long PersonDocumentId { get; set; }

    public string PersonDocumentDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long DocumentId { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public string? DocumentInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
