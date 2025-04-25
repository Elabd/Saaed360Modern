using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistRequestRejectionReasonDim
{
    public Guid RejectionReasonId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string Code { get; set; } = null!;

    public string RejectionReasonNameEn { get; set; } = null!;

    public string RejectionReasonNameAr { get; set; } = null!;

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual ICollection<RoadAssistRequest> RoadAssistRequests { get; set; } = new List<RoadAssistRequest>();
}
