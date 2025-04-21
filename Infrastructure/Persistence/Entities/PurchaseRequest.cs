using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PurchaseRequest
{
    public long PurchaseRequestId { get; set; }

    public int ReportId { get; set; }

    public int VehicleDataId { get; set; }

    public DateTime CreateDate { get; set; }

    public int LastStatusId { get; set; }

    public bool? IsDelayed { get; set; }

    public long? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public bool IsDeleted { get; set; }

    public decimal? SubmittedOfferValue { get; set; }

    public decimal? BuyPrice { get; set; }

    public virtual Person? LastModifiedByNavigation { get; set; }

    public virtual PurchaseRequestStatus LastStatus { get; set; } = null!;

    public virtual ICollection<PurchaseRequestComment> PurchaseRequestComments { get; set; } = new List<PurchaseRequestComment>();

    public virtual ICollection<PurchaseRequestLog> PurchaseRequestLogs { get; set; } = new List<PurchaseRequestLog>();

    public virtual Report Report { get; set; } = null!;

    public virtual VehicleDatum VehicleData { get; set; } = null!;
}
