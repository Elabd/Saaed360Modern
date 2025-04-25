using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistUserVehicle
{
    public Guid UserVehicleId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public Guid UserId { get; set; }

    public Guid VehicleId { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual ICollection<RoadAssistRequest> RoadAssistRequests { get; set; } = new List<RoadAssistRequest>();

    public virtual RoadAssistUser User { get; set; } = null!;

    public virtual RoadAssistVehicle Vehicle { get; set; } = null!;
}
