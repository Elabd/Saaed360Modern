using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentReturnToOrreasonsDim
{
    public int IncidentReturnToOrreasonsId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int IsDeleted { get; set; }

    public virtual ICollection<SmartDispatchingReturnToOperationRoomLog> SmartDispatchingReturnToOperationRoomLogs { get; set; } = new List<SmartDispatchingReturnToOperationRoomLog>();
}
