using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportRequestDocument
{
    public long RequestDocumentId { get; set; }

    public string? DocumentName { get; set; }

    public string? BinaryDescriptionText { get; set; }

    public byte[]? BinaryBase64Object { get; set; }

    public byte[]? BinaryHexObject { get; set; }

    public long? BinarySize { get; set; }

    public int? DocumentTypeId { get; set; }

    public int? FileFormatId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public long? RequestId { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual DocumentCategoryDim? DocumentType { get; set; }

    public virtual DocumentFormatDim? FileFormat { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ReportRequest? Request { get; set; }
}
