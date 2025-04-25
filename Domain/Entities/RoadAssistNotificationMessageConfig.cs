using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistNotificationMessageConfig
{
    public Guid NotificationId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string NotificationCode { get; set; } = null!;

    public int? SmsmessageCode { get; set; }

    public string? WhatsAppMessageCode { get; set; }

    public string? EmailSubjectEn { get; set; }

    public string? EmailSubjectAr { get; set; }

    public string? EmailBodyTemplateEn { get; set; }

    public string? EmailBodyTemplateAr { get; set; }

    public bool WhatsappEnabled { get; set; }

    public bool EmailEnabled { get; set; }

    public bool Smsenabled { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }
}
