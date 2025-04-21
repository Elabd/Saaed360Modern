using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistFuelPackageDim
{
    public Guid FuelPackageId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string Code { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int Package { get; set; }

    public string FuelPackageNameEn { get; set; } = null!;

    public string FuelPackageNameAr { get; set; } = null!;

    public virtual ICollection<RoadAssistFuelFeesPerUnit> RoadAssistFuelFeesPerUnits { get; set; } = new List<RoadAssistFuelFeesPerUnit>();

    public virtual ICollection<RoadAssistRequest> RoadAssistRequests { get; set; } = new List<RoadAssistRequest>();
}
