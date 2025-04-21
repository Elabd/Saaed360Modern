using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DirectPaymentTransaction
{
    public long DirectPaymentTransactionId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? ReportId { get; set; }

    public int? DirectPaymentReasonId { get; set; }

    public int? LatestDirectPaymentStatusId { get; set; }

    public int? VehicleDataId { get; set; }

    public int? DirectPaymentSourceId { get; set; }

    public string? StrReason { get; set; }

    public virtual DirectPaymentReasonDim? DirectPaymentReason { get; set; }
}
