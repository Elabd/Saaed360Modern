using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PaymentAccountOperation
{
    public long Id { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public long? PaymentInfoId { get; set; }

    public string? MerchantRefrence { get; set; }

    public string? PaymentReference { get; set; }

    public int? BankOperationType { get; set; }

    public int? PaymenMethodType { get; set; }

    public decimal? ServiceAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? PaymentGateWayFees { get; set; }

    public decimal? Vat { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? UserId { get; set; }

    public int? PaymentStatus { get; set; }

    public int? CallBackStatus { get; set; }

    public virtual PaymentOrganizationInfo? PaymentInfo { get; set; }
}
