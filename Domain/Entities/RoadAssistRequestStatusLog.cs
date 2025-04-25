using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistRequestStatusLog
{
    public Guid RequestStatusLogId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public Guid RequestId { get; set; }

    public Guid RequestStatusId { get; set; }

    public Guid? ProviderId { get; set; }

    public Guid? ProviderBranchId { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual RoadAssistProvider? Provider { get; set; }

    public virtual RoadAssistProviderBranch? ProviderBranch { get; set; }

    public virtual RoadAssistRequest Request { get; set; } = null!;

    public virtual RoadAssistRequestStatusDim RequestStatus { get; set; } = null!;
}
