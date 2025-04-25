using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PurchaseRequestStatus
{
    public int PurchaseRequestStatusId { get; set; }

    public string PurchaseRequestStatusArabic { get; set; } = null!;

    public string PurchaseRequestStatusEnglish { get; set; } = null!;

    public string PurchaseRequestStatusCode { get; set; } = null!;

    public bool? IsAfterSubmittingStatus { get; set; }

    public virtual ICollection<PurchaseRequestComment> PurchaseRequestComments { get; set; } = new List<PurchaseRequestComment>();

    public virtual ICollection<PurchaseRequestLog> PurchaseRequestLogs { get; set; } = new List<PurchaseRequestLog>();

    public virtual ICollection<PurchaseRequest> PurchaseRequests { get; set; } = new List<PurchaseRequest>();
}
