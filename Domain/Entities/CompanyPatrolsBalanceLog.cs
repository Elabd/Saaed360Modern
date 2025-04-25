using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CompanyPatrolsBalanceLog
{
    public long Id { get; set; }

    public long CompanyId { get; set; }

    public int OldPatrolBalance { get; set; }

    public int PatrolBalanceChange { get; set; }

    public int PatrolBalanceTypeId { get; set; }

    public long EscortId { get; set; }

    public long CompanyPatrolsBalanceId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public long? CreatedBy { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual CompanyPatrolsBalance CompanyPatrolsBalance { get; set; } = null!;

    public virtual Escort Escort { get; set; } = null!;
}
