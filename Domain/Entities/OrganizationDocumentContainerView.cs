using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationDocumentContainerView
{
    public long OrganizationDocumentId { get; set; }

    public string OrganizationDocumentDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public long DocumentId { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public string? DocumentInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
