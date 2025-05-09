using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemDocumentView
{
    public long DocumentId { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? DocumentCategoryCode { get; set; }

    public string? DocumentCategoryDescription { get; set; }

    public string? DocumentFormatCode { get; set; }

    public string? DocumentFormatDescription { get; set; }

    public string? DocumentStatusCode { get; set; }

    public string? DocumentStatusDescription { get; set; }

    public string? Title { get; set; }

    public string? FileName { get; set; }

    public string? FileExtension { get; set; }

    public DateTime? FileDateTime { get; set; }

    public string? FileControlNumber { get; set; }

    public string? Description { get; set; }

    public string? DocumentUri { get; set; }

    public byte[]? FileBody { get; set; }

    public string? FileBodyXml { get; set; }

    public bool? PermanentRecordIndicator { get; set; }

    public bool? PrivacyActIndicator { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public long ItemDocumentId { get; set; }

    public string ItemDocumentDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public string? DocumentInvolvementDescription { get; set; }
}
