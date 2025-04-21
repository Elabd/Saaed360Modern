using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistUserType
{
    public Guid UserTypeId { get; set; }

    public string UserTypeCode { get; set; } = null!;

    public virtual ICollection<RoadAssistIntegrationTokenLog> RoadAssistIntegrationTokenLogs { get; set; } = new List<RoadAssistIntegrationTokenLog>();

    public virtual ICollection<RoadAssistUser> RoadAssistUsers { get; set; } = new List<RoadAssistUser>();
}
