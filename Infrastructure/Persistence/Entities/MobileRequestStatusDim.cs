using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileRequestStatusDim
{
    public int MobileRequestStatusId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public bool Isdeleted { get; set; }

    public bool? IsClosedReason { get; set; }

    public virtual ICollection<MobileRequest> MobileRequests { get; set; } = new List<MobileRequest>();

    public virtual ICollection<MobileStatusMessagesDim> MobileStatusMessagesDims { get; set; } = new List<MobileStatusMessagesDim>();
}
