using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityTransaction
{
    public long TransationId { get; set; }

    public long ActivityId { get; set; }

    public int TransationTypeId { get; set; }

    public long? ItemId { get; set; }

    public long? OrganizationId { get; set; }

    public int StatusId { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreationDateTime { get; set; }

    public string? Temp { get; set; }

    public long? TempId { get; set; }

    public long? Teid { get; set; }

    public bool? IsAutoDispatch { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Person CreatedByNavigation { get; set; } = null!;

    public virtual Item? Item { get; set; }

    public virtual Organization? Organization { get; set; }

    public virtual StatusDim Status { get; set; } = null!;

    public virtual Person? Te { get; set; }

    public virtual TransactionType TransationType { get; set; } = null!;
}
