using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OfflineOperation
{
    public long OfflineOperationId { get; set; }

    public long? OperationTypeId { get; set; }

    public long? OfflineDtoId { get; set; }

    public long? ActivityId { get; set; }

    public bool? IsSynced { get; set; }

    public long UserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public virtual OfflineIncident? Activity { get; set; }

    public virtual OfflineDto? OfflineDto { get; set; }

    public virtual OperationTypeDim? OperationType { get; set; }
}
