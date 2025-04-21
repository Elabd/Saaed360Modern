using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistServiceStatusDim
{
    public Guid ServiceStatusId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string Code { get; set; } = null!;

    public string ServiceStatusNameEn { get; set; } = null!;

    public string ServiceStatusNameAr { get; set; } = null!;

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual ICollection<RoadAssistProviderService> RoadAssistProviderServices { get; set; } = new List<RoadAssistProviderService>();
}

