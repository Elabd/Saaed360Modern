using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairComment
{
    public long Id { get; set; }

    public long RepairRequestId { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public long CreatedByPersonId { get; set; }

    public long? LastModifiedBy { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Person CreatedByPerson { get; set; } = null!;

    public virtual RepairRequest RepairRequest { get; set; } = null!;
}
