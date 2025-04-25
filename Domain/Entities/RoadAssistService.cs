using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistService
{
    public Guid ServiceId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string ServiceTitleEn { get; set; } = null!;

    public string ServiceTitleAr { get; set; } = null!;

    public string ServiceCode { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public bool? IsActive { get; set; }

    public bool? IsComingSoon { get; set; }

    public int? OrderIndex { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual ICollection<RoadAssistProviderService> RoadAssistProviderServices { get; set; } = new List<RoadAssistProviderService>();

    public virtual ICollection<RoadAssistRequest> RoadAssistRequests { get; set; } = new List<RoadAssistRequest>();
}

