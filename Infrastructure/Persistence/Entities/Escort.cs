using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Escort
{
    public long EscortId { get; set; }

    public long RequestNumber { get; set; }

    public int EscortTypeId { get; set; }

    public long? CompanyId { get; set; }

    public int? CurrentRequestStepId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public DateTime? ModifictionDateTime { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ICollection<CompanyPatrolsBalanceLog> CompanyPatrolsBalanceLogs { get; set; } = new List<CompanyPatrolsBalanceLog>();

    public virtual ICollection<EscortAttachment> EscortAttachments { get; set; } = new List<EscortAttachment>();

    public virtual ICollection<EscortInfo> EscortInfos { get; set; } = new List<EscortInfo>();

    public virtual ICollection<EscortMission> EscortMissions { get; set; } = new List<EscortMission>();

    public virtual ICollection<EscortRequestStep> EscortRequestSteps { get; set; } = new List<EscortRequestStep>();

    public virtual EscortTypeDim EscortType { get; set; } = null!;

    public virtual ICollection<EscortVehicle> EscortVehicles { get; set; } = new List<EscortVehicle>();

    public virtual ICollection<RemainingCompanyPatrolsAction> RemainingCompanyPatrolsActions { get; set; } = new List<RemainingCompanyPatrolsAction>();
}
