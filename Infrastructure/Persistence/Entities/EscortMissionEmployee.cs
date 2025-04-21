using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EscortMissionEmployee
{
    public long EscortMissionEmployeeId { get; set; }

    public long EscortMissionId { get; set; }

    public long PersonId { get; set; }

    public bool IsNotified { get; set; }

    public int EmployeeWorkType { get; set; }

    public virtual EscortMission EscortMission { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
