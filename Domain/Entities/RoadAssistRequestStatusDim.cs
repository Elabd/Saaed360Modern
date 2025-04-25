using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistRequestStatusDim
{
    public Guid RequestStatusId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string Code { get; set; } = null!;

    public string RequestStatusNameEn { get; set; } = null!;

    public string RequestStatusNameAr { get; set; } = null!;

    public bool IsClosed { get; set; }

    public string? RequestStatusColor { get; set; }

    public string? ActionRequestStatusNameEn { get; set; }

    public string? ActionRequestStatusNameAr { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual ICollection<RoadAssistActivityFlowMapping> RoadAssistActivityFlowMappings { get; set; } = new List<RoadAssistActivityFlowMapping>();

    public virtual ICollection<RoadAssistRequestStatusLog> RoadAssistRequestStatusLogs { get; set; } = new List<RoadAssistRequestStatusLog>();

    public virtual ICollection<RoadAssistRequest> RoadAssistRequests { get; set; } = new List<RoadAssistRequest>();

    public virtual ICollection<RoadAssistStatusFlowMapping> RoadAssistStatusFlowMappingCurrentStatuses { get; set; } = new List<RoadAssistStatusFlowMapping>();

    public virtual ICollection<RoadAssistStatusFlowMapping> RoadAssistStatusFlowMappingNextStatuses { get; set; } = new List<RoadAssistStatusFlowMapping>();
}
