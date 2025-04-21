using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistActivityFlowMapping
{
    public Guid ActivityFlowId { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? CurrentStatusId { get; set; }

    public Guid? NextActivityId { get; set; }

    public int ActivityFlowOrder { get; set; }

    public Guid? MappedActivityToStatusId { get; set; }

    public virtual RoadAssistUser? CreatedByUser { get; set; }

    public virtual RoadAssistRequestStatusDim? CurrentStatus { get; set; }

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual RoadAssistRequestActivityDim? NextActivity { get; set; }
}
