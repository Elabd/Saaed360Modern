using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Realestate
{
    public long ItemId { get; set; }

    public long? RealestateLocationId { get; set; }

    public Guid RealestateLocationGuid { get; set; }

    public int? RealestateCategoryId { get; set; }

    public int? RealestateAttachedFacilityId { get; set; }

    public string? Acreage { get; set; }

    public string? Boundry { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual RealestateAttachedFacilityDim? RealestateAttachedFacility { get; set; }

    public virtual RealestateCategoryDim? RealestateCategory { get; set; }

    public virtual Location? RealestateLocation { get; set; }
}
