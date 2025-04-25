using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistFuelFeesPerUnit
{
    public Guid FuelFeesPerUnitId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? ProviderId { get; set; }

    public Guid FuelTypeId { get; set; }

    public decimal PricePerUnit { get; set; }

    public DateTime EffectiveStartDate { get; set; }

    public DateTime? EffectiveEndDate { get; set; }

    public Guid FuelPackageId { get; set; }

    public Guid? ProviderBranchId { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistFuelPackageDim FuelPackage { get; set; } = null!;

    public virtual RoadAssistFuelTypeDim FuelType { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual RoadAssistProvider? Provider { get; set; }

    public virtual RoadAssistProviderBranch? ProviderBranch { get; set; }

    public virtual ICollection<RoadAssistRequest> RoadAssistRequests { get; set; } = new List<RoadAssistRequest>();
}
