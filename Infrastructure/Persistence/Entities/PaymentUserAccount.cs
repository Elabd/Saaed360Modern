using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PaymentUserAccount
{
    public int Id { get; set; }

    public string UserAccount { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? SettlementPeriod { get; set; }

    public virtual ICollection<PaymentOrganizationInfo> PaymentOrganizationInfos { get; set; } = new List<PaymentOrganizationInfo>();

    public virtual ICollection<PaymentRequestTypeDim> PaymentRequestTypeDims { get; set; } = new List<PaymentRequestTypeDim>();

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();
}
