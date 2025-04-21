using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileStatusMessagesDim
{
    public int MobileStatusMessageId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public bool Isdeleted { get; set; }

    public int? ActivityReasonId { get; set; }

    public int StatusId { get; set; }

    public virtual ActivityReasonDim? ActivityReason { get; set; }

    public virtual MobileRequestStatusDim Status { get; set; } = null!;
}
