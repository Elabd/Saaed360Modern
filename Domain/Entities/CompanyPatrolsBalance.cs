using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CompanyPatrolsBalance
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public int? PatrolsBalance { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public DateTime? LastModifictionDateTime { get; set; }

    public virtual ICollection<CompanyPatrolsBalanceLog> CompanyPatrolsBalanceLogs { get; set; } = new List<CompanyPatrolsBalanceLog>();

    public virtual Company IdNavigation { get; set; } = null!;
}
