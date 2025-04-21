using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PaymentNotification
{
    public int NotificationId { get; set; }

    public int? NotificationType { get; set; }

    public DateTime? TransactionDateTime { get; set; }

    public string? EvgpaymentReference { get; set; }

    public int? PaymentStatus { get; set; }

    public int? ResponseCode { get; set; }

    public string? ResponseDescription { get; set; }

    public string? RejectionReason { get; set; }

    public int? CallbackStatus { get; set; }
}
