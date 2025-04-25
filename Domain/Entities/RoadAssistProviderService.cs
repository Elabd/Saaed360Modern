using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistProviderService
{
    public Guid ProviderServiceId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? ProviderId { get; set; }

    public Guid ServiceId { get; set; }

    public Guid ServiceStatusId { get; set; }

    public Guid? ProviderBranchId { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual RoadAssistProvider? Provider { get; set; }

    public virtual RoadAssistProviderBranch? ProviderBranch { get; set; }

    public virtual ICollection<RoadAssistSaaedShareValue> RoadAssistSaaedShareValues { get; set; } = new List<RoadAssistSaaedShareValue>();

    public virtual ICollection<RoadAssistServicePriceByDistance> RoadAssistServicePriceByDistances { get; set; } = new List<RoadAssistServicePriceByDistance>();

    public virtual ICollection<RoadAssistServicePriceByEmirate> RoadAssistServicePriceByEmirates { get; set; } = new List<RoadAssistServicePriceByEmirate>();

    public virtual RoadAssistService Service { get; set; } = null!;

    public virtual RoadAssistServiceStatusDim ServiceStatus { get; set; } = null!;
}

