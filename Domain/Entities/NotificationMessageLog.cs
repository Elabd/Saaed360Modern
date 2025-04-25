using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NotificationMessageLog
{
    public long MessageLogId { get; set; }

    public int MessageTemplateId { get; set; }

    public string MessageTemplateLanguage { get; set; } = null!;

    public string SenderMobileNumber { get; set; } = null!;

    public string ReceiverMobileNumber { get; set; } = null!;

    public string? ReferenceRequestId { get; set; }

    public bool? IsSent { get; set; }

    public DateTime? SentDate { get; set; }

    public bool? IsReceived { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public bool? IsRead { get; set; }

    public DateTime? ReadDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? ErrorMessage { get; set; }

    public virtual ICollection<AccidentFeereminderMessage> AccidentFeereminderMessages { get; set; } = new List<AccidentFeereminderMessage>();

    public virtual NotificationMessageTemplate MessageTemplate { get; set; } = null!;

    public virtual ICollection<NotificationMessageLogDetail> NotificationMessageLogDetails { get; set; } = new List<NotificationMessageLogDetail>();
}
