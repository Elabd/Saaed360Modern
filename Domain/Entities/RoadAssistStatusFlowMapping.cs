using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistStatusFlowMapping
{
    public Guid StatusFlowId { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? CurrentStatusId { get; set; }

    public Guid? NextStatusId { get; set; }

    public virtual RoadAssistUser? CreatedByUser { get; set; }

    public virtual RoadAssistRequestStatusDim? CurrentStatus { get; set; }

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual RoadAssistRequestStatusDim? NextStatus { get; set; }
}
