using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Aircraft
{
    public long ItemId { get; set; }

    public long? BaseAirportLocationId { get; set; }

    public Guid? BaseAirportLocationGuid { get; set; }

    public int? AircraftCategoryId { get; set; }

    public int? FuselageColorId { get; set; }

    public int? WingColorId { get; set; }

    public int? AircraftUsageId { get; set; }

    public string? TailIndentification { get; set; }

    public int? EngineQuantity { get; set; }

    public int? EngineCylinderQuantity { get; set; }

    public virtual AircraftCategoryDim? AircraftCategory { get; set; }

    public virtual AircraftUsageDim? AircraftUsage { get; set; }

    public virtual Location? BaseAirportLocation { get; set; }

    public virtual ItemColorDim? FuselageColor { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual ItemColorDim? WingColor { get; set; }
}
