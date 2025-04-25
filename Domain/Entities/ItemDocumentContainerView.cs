using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemDocumentContainerView
{
    public long ItemDocumentId { get; set; }

    public string ItemDocumentDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public long DocumentId { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public string? DocumentInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
