using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileRequestRejectionReasonDim
{
    public int MobileRequestRejectionReasonId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public bool Isdeleted { get; set; }

    public int? ActivityReasonId { get; set; }

    public virtual ActivityReasonDim? ActivityReason { get; set; }
}
