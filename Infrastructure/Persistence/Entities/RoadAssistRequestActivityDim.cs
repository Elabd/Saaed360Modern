using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistRequestActivityDim
{
    public Guid RequestActivityId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string Code { get; set; } = null!;

    public string RequestActivityNameEn { get; set; } = null!;

    public string RequestActivityNameAr { get; set; } = null!;

    public int ActivityOrder { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual ICollection<RoadAssistActivityFlowMapping> RoadAssistActivityFlowMappings { get; set; } = new List<RoadAssistActivityFlowMapping>();
}
