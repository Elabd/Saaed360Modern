using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PaymentOrganizationInfo
{
    public long PaymentInfoId { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? ParticipantCode { get; set; }

    public string? IdentificationNo { get; set; }

    public long? WalletNo { get; set; }

    public double? WalletBalance { get; set; }

    public DateTime? BalanceLastUpdate { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CompanyInfoId { get; set; }

    public int? RegistrationStatus { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public int? ParticipantType { get; set; }

    public string? ParticipantNameAr { get; set; }

    public string? ParticipantNameEn { get; set; }

    public int? PaymentUserAccountId { get; set; }

    public virtual ICollection<PaymentAccountOperation> PaymentAccountOperations { get; set; } = new List<PaymentAccountOperation>();

    public virtual ICollection<PaymentBankAccount> PaymentBankAccounts { get; set; } = new List<PaymentBankAccount>();

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    public virtual PaymentUserAccount? PaymentUserAccount { get; set; }
}
