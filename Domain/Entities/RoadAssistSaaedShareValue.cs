using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistSaaedShareValue
{
    public Guid SaaedShareValueId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public Guid ProviderServiceId { get; set; }

    public DateTime EffectiveStartDate { get; set; }

    public DateTime? EffectiveEndDate { get; set; }

    public decimal Percentage { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual RoadAssistProviderService ProviderService { get; set; } = null!;

    public virtual ICollection<RoadAssistRequest> RoadAssistRequests { get; set; } = new List<RoadAssistRequest>();
}
