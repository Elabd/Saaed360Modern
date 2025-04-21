using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PaymentBankAccount
{
    public int AccountId { get; set; }

    public string? Iban { get; set; }

    public string? SwiftCode { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public int? AccountType { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public long? PaymentInfoId { get; set; }

    public string? DirectDebitReference { get; set; }

    public virtual PaymentOrganizationInfo? PaymentInfo { get; set; }
}
