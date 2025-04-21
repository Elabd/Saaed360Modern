using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistServicePriceByEmirate
{
    public Guid ServicePriceByEmirateId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public long DistinationEmirateId { get; set; }

    public decimal? GoingPrice { get; set; }

    public decimal? ReturningPrice { get; set; }

    public DateTime EffectiveStartDate { get; set; }

    public DateTime? EffectiveEndDate { get; set; }

    public Guid? ProviderServiceId { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual EmirateDim DistinationEmirate { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual RoadAssistProviderService? ProviderService { get; set; }

    public virtual ICollection<RoadAssistRequest> RoadAssistRequests { get; set; } = new List<RoadAssistRequest>();
}

