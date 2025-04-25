using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OfflineDto
{
    public long OfflineDtoId { get; set; }

    public long? ActivityId { get; set; }

    public long? DtoTypeId { get; set; }

    public string SerializedDto { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsSynced { get; set; }

    public virtual OfflineIncident? Activity { get; set; }

    public virtual DtoTypeDim? DtoType { get; set; }

    public virtual ICollection<OfflineOperation> OfflineOperations { get; set; } = new List<OfflineOperation>();
}
