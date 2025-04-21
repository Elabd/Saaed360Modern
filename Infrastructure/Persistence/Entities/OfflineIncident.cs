using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OfflineIncident
{
    public long ActivityId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<OfflineDto> OfflineDtos { get; set; } = new List<OfflineDto>();

    public virtual ICollection<OfflineOperation> OfflineOperations { get; set; } = new List<OfflineOperation>();
}
