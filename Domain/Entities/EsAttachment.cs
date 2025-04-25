using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsAttachment
{
    public int Id { get; set; }

    public int Index { get; set; }

    public int ServiceId { get; set; }

    public string NameArabic { get; set; } = null!;

    public string NameEnglish { get; set; } = null!;

    public string NameUrdu { get; set; } = null!;

    public int DocumentTypeId { get; set; }

    public int MaxAttachmentSize { get; set; }

    public bool IsMultiple { get; set; }

    public int? MaxAttachmentsCount { get; set; }

    public bool IsRequired { get; set; }

    public int? IsRequiredAfterDays { get; set; }

    public int? ConditionId { get; set; }

    public string? ConditionValue { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual EsConditionDim? Condition { get; set; }

    public virtual ObjectionCustomerDocumentTypeDim DocumentType { get; set; } = null!;

    public virtual EsService Service { get; set; } = null!;
}
