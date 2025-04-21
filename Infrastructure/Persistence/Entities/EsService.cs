using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EsService
{
    public int Id { get; set; }

    public string NameArabic { get; set; } = null!;

    public string NameEnglish { get; set; } = null!;

    public string NameUrdu { get; set; } = null!;

    public int ObjectionRequestTypeId { get; set; }

    public string Icon { get; set; } = null!;

    public string DescriptionArabic { get; set; } = null!;

    public string DescriptionEnglish { get; set; } = null!;

    public string DescriptionUrdu { get; set; } = null!;

    public string ProcessingTimeArabic { get; set; } = null!;

    public string ProcessingTimeEnglish { get; set; } = null!;

    public string ProcessingTimeUrdu { get; set; } = null!;

    public decimal FeesValue { get; set; }

    public string FeesArabic { get; set; } = null!;

    public string FeesEnglish { get; set; } = null!;

    public string FeesUrdu { get; set; } = null!;

    public bool? IsPrepaid { get; set; }

    public bool IsListedInDashboard { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public int? PaymentRequestId { get; set; }

    public virtual ICollection<EsAttachment> EsAttachments { get; set; } = new List<EsAttachment>();

    public virtual ICollection<EsInput> EsInputs { get; set; } = new List<EsInput>();

    public virtual ICollection<EsStep> EsSteps { get; set; } = new List<EsStep>();

    public virtual ObjectionRequestType ObjectionRequestType { get; set; } = null!;

    public virtual PaymentRequestTypeDim? PaymentRequest { get; set; }
}

