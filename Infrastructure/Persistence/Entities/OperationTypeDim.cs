using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OperationTypeDim
{
    public long OperationTypeId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<OfflineOperation> OfflineOperations { get; set; } = new List<OfflineOperation>();
}
