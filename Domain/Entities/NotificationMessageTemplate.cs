using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NotificationMessageTemplate
{
    public int MessageTemplateId { get; set; }

    public string MessageTemplateCode { get; set; } = null!;

    public string MessageTemplateName { get; set; } = null!;

    public string MessageTemplateDescription { get; set; } = null!;

    public string? MessageTemplateParametersDefinition { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<NotificationMessageLog> NotificationMessageLogs { get; set; } = new List<NotificationMessageLog>();

    public virtual ICollection<SmstoWhatsMapping> SmstoWhatsMappings { get; set; } = new List<SmstoWhatsMapping>();
}

