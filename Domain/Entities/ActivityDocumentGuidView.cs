using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityDocumentGuidView
{
    public Guid DocumentGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? DocumentCategoryCode { get; set; }

    public string? DocumentFormatCode { get; set; }

    public string? DocumentStatusCode { get; set; }

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

    public Guid ActivityDocumentGuid { get; set; }

    public string ActivityDocumentDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public string? DocumentInvolvementCode { get; set; }
}
