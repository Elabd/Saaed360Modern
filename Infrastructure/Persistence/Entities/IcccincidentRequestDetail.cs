using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccincidentRequestDetail
{
    public int Id { get; set; }

    public long? IcccincidentId { get; set; }

    public long PersonId { get; set; }

    public long? PatrolId { get; set; }

    public DateTime? DispatchTime { get; set; }

    public long AreaId { get; set; }

    public string? AvailableCandidates { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? ConfirmationTime { get; set; }

    public decimal? ExpectedTime { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual IcccincidentRequest? Icccincident { get; set; }
}
