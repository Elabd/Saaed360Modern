using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistFuelTypeDim
{
    public Guid FuelTypeId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string Code { get; set; } = null!;

    public string FuelTypeNameEn { get; set; } = null!;

    public string FuelTypeNameAr { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual ICollection<RoadAssistFuelFeesPerUnit> RoadAssistFuelFeesPerUnits { get; set; } = new List<RoadAssistFuelFeesPerUnit>();

    public virtual ICollection<RoadAssistRequest> RoadAssistRequests { get; set; } = new List<RoadAssistRequest>();
}
