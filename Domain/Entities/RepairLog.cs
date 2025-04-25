using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RepairLog
{
    public long Id { get; set; }

    public long RepairRequestId { get; set; }

    public long LastModifiedBy { get; set; }

    public DateTime LastModificationDate { get; set; }

    public virtual Person LastModifiedByNavigation { get; set; } = null!;

    public virtual RepairRequest RepairRequest { get; set; } = null!;
}
