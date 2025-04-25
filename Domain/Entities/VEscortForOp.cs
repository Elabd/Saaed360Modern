using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VEscortForOp
{
    public long RequestNumber { get; set; }

    public string Company { get; set; } = null!;

    public DateTime? EscortDateFrom { get; set; }

    public DateTime? EscortDateTo { get; set; }

    public long? EscortMissionId { get; set; }

    public DateTime? MissionDate { get; set; }

    public int? NumberOfPatrols { get; set; }

    public string? LocationFrom { get; set; }

    public string? LocationTo { get; set; }

    public string? Patrol { get; set; }

    public long? PatrolId { get; set; }

    public string? CurrentStatus { get; set; }

    public string? RejectionReason { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string? Notes { get; set; }

    public long? EscortMissionPatrolId { get; set; }
}
