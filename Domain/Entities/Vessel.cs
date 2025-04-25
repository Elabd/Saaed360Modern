using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Vessel
{
    public long ItemId { get; set; }

    public int? GeoCountryId { get; set; }

    public int? VesselCategoryId { get; set; }

    public int? VesselHullShapeId { get; set; }

    public int? VesselHullMaterialId { get; set; }

    public int? VesselPropulsionTypeId { get; set; }

    public string? OfficalCoastGuardNumber { get; set; }

    public string? Imonumber { get; set; }

    public string? Mmsinumber { get; set; }

    public string? VesselRegistrationNumber { get; set; }

    public string? RegistrationNumber { get; set; }

    public string? SailNumber { get; set; }

    public string? LicenseNumber { get; set; }

    public string? HullIdentification { get; set; }

    public string? InternationalRadioCallSign { get; set; }

    public string? PortOfRegistry { get; set; }

    public double? CruiseRangeMeasure { get; set; }

    public double? CruiseSpeedMeasure { get; set; }

    public double? DeadWeightMeasure { get; set; }

    public int? EngineQuanity { get; set; }

    public int? EngineCylinderQuantity { get; set; }

    public virtual GeoCountryDim? GeoCountry { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual VesselCategoryDim? VesselCategory { get; set; }

    public virtual VesselHullMaterialDim? VesselHullMaterial { get; set; }

    public virtual VesselHullShapeDim? VesselHullShape { get; set; }

    public virtual VesselPropulsionTypeDim? VesselPropulsionType { get; set; }
}
