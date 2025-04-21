using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RemainingCompanyPatrolsActionType
{
    public int Id { get; set; }

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public virtual ICollection<RemainingCompanyPatrolsAction> RemainingCompanyPatrolsActions { get; set; } = new List<RemainingCompanyPatrolsAction>();
}
