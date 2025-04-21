using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DrivingIncident
{
    public long ActivityId { get; set; }

    public int? DrivingCmvid { get; set; }

    public int? DrivingHazMatId { get; set; }

    public int? DrivingRoadCategoryId { get; set; }

    public int? DrivingRoadConditionId { get; set; }

    public int? DrivingTrafficConditionId { get; set; }

    public int? DrivingWeatherConditionId { get; set; }

    public int? DrivingAccidentSeverityId { get; set; }

    public int? LegalSpeedRate { get; set; }

    public int? RecordedSpeedRate { get; set; }

    public bool? CollisionIndicator { get; set; }

    public bool? MobilePhoneIndicator { get; set; }

    public bool? SeatbeltUsedIndicator { get; set; }

    public bool? DriverOwnershipIndicator { get; set; }

    public int? NumberPedestrianInvolved { get; set; }

    public string? PassengerDescrption { get; set; }

    public int? PassengerQuantity { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual DrivingAccidentSeverityDim? DrivingAccidentSeverity { get; set; }

    public virtual DrivingCmvdim? DrivingCmv { get; set; }

    public virtual DrivingHazMatDim? DrivingHazMat { get; set; }

    public virtual DrivingRoadCategoryDim? DrivingRoadCategory { get; set; }

    public virtual DrivingRoadConditionDim? DrivingRoadCondition { get; set; }

    public virtual DrivingTrafficConditionDim? DrivingTrafficCondition { get; set; }

    public virtual DrivingWeatherConditionDim? DrivingWeatherCondition { get; set; }
}
