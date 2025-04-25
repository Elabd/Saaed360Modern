using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityConvertToStation
{
    public long Id { get; set; }

    public long ActivityId { get; set; }

    public int ActivityReasonId { get; set; }

    public int StatusId { get; set; }

    public DateTime Createdtime { get; set; }

    public long CreatedBy { get; set; }

    public long OrganizationId { get; set; }

    public string? Comment { get; set; }

    public bool IsCurrentOrganization { get; set; }

    public int TransferStatusId { get; set; }

    public long? LastModifiedBy { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual ActivityReasonDim ActivityReason { get; set; } = null!;

    public virtual Person CreatedByNavigation { get; set; } = null!;

    public virtual Organization Organization { get; set; } = null!;

    public virtual StatusDim Status { get; set; } = null!;
}
