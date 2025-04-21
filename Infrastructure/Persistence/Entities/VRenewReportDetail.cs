using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VRenewReportDetail
{
    public long ObjectionId { get; set; }

    public DateTime ObjectionDate { get; set; }

    public int ObjectionStatusId { get; set; }

    public int? RequestTypeId { get; set; }

    public int? PaymentStatusId { get; set; }

    public long? TransactionId { get; set; }

    public int NewStatusId { get; set; }

    public int? NewPaymentStatusId { get; set; }
}
