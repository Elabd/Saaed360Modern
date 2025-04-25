using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PaymentRequestTypeDim
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? Description { get; set; }

    public string? PredefinedCode { get; set; }

    public bool? IsPredifinedService { get; set; }

    public string? AfterPaymentReturnUrl { get; set; }

    public string? VatPredefinedCode { get; set; }

    public int? PaymentAccountId { get; set; }

    public bool? IsRefundable { get; set; }

    public virtual ICollection<EsService> EsServices { get; set; } = new List<EsService>();

    public virtual PaymentUserAccount? PaymentAccount { get; set; }

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();
}
