using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistRequest
{
    public Guid RequestId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string RequestNumber { get; set; } = null!;

    public Guid? UserVehicleId { get; set; }

    public Guid ServiceId { get; set; }

    public decimal? RequesterCurrentLat { get; set; }

    public decimal? RequesterCurrentLong { get; set; }

    public DateTime RequestScheduleStartTime { get; set; }

    public DateTime RequestScheduleEndTime { get; set; }

    public long ServiceDeliveryLocationEmirateId { get; set; }

    public decimal ServiceDeliveryLocationLat { get; set; }

    public decimal ServiceDeliveryLocationLong { get; set; }

    public string ServiceDeliveryLocationName { get; set; } = null!;

    public long? ServiceDeliveryDistinationEmirateId { get; set; }

    public decimal? ServiceDeliveryDistinationLat { get; set; }

    public decimal? ServiceDeliveryDistinationLong { get; set; }

    public string? ServiceDeliveryDistinationName { get; set; }

    public decimal? LocationsDistanceKm { get; set; }

    public Guid? ProviderId { get; set; }

    public decimal? RequestTotalFees { get; set; }

    public int? ExpectedArrivalMinutes { get; set; }

    public string? PaymentRecieptDocUrl { get; set; }

    public Guid? RiderId { get; set; }

    public byte? ApplicantServiceRateValue { get; set; }

    public string? ApplicantServiceRateComment { get; set; }

    public byte? ApplicantProviderRateValue { get; set; }

    public string? ApplicantProviderRateComment { get; set; }

    public Guid? AppliedSaaedShareValueId { get; set; }

    public decimal? AppliedSaaedShareCalculatedValue { get; set; }

    public bool? NeedBasementTowing { get; set; }

    public bool? CarGearOnNeutral { get; set; }

    public Guid? FuelPackageId { get; set; }

    public Guid? FuelTypeId { get; set; }

    public long RequestReferenceId { get; set; }

    public Guid? RoadAssistRequestRejectionReasonId { get; set; }

    public string? UnreachableReasonDescription { get; set; }

    public Guid? FuelFeesPerUnitId { get; set; }

    public Guid? ProviderVehicleId { get; set; }

    public Guid RequestStatusId { get; set; }

    public Guid? ServicePriceByEmirateId { get; set; }

    public Guid? ServicePriceByDistanceId { get; set; }

    public DateTime? ArrivalEtabaseDateTime { get; set; }

    public decimal? DriverCurrentLat { get; set; }

    public decimal? DriverCurrentLong { get; set; }

    public byte[]? Version { get; set; }

    public decimal? AppliedProviderShareCalculatedValue { get; set; }

    public Guid? AppliedVatValueId { get; set; }

    public string? CancelReasonDescription { get; set; }

    public string? LanguageCode { get; set; }

    public Guid? ProviderBranchId { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? VehicleCondition { get; set; }

    public string? ApplicantMobileNumber { get; set; }

    public virtual RoadAssistSaaedShareValue? AppliedSaaedShareValue { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistFuelFeesPerUnit? FuelFeesPerUnit { get; set; }

    public virtual RoadAssistFuelPackageDim? FuelPackage { get; set; }

    public virtual RoadAssistFuelTypeDim? FuelType { get; set; }

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual RoadAssistProvider? Provider { get; set; }

    public virtual RoadAssistProviderBranch? ProviderBranch { get; set; }

    public virtual RoadAssistProviderVehicle? ProviderVehicle { get; set; }

    public virtual RoadAssistRequestStatusDim RequestStatus { get; set; } = null!;

    public virtual RoadAssistRider? Rider { get; set; }

    public virtual ICollection<RoadAssistRatingNotificationLog> RoadAssistRatingNotificationLogs { get; set; } = new List<RoadAssistRatingNotificationLog>();

    public virtual ICollection<RoadAssistRequestComment> RoadAssistRequestComments { get; set; } = new List<RoadAssistRequestComment>();

    public virtual ICollection<RoadAssistRequestFee> RoadAssistRequestFees { get; set; } = new List<RoadAssistRequestFee>();

    public virtual RoadAssistRequestRejectionReasonDim? RoadAssistRequestRejectionReason { get; set; }

    public virtual ICollection<RoadAssistRequestStatusLog> RoadAssistRequestStatusLogs { get; set; } = new List<RoadAssistRequestStatusLog>();

    public virtual RoadAssistService Service { get; set; } = null!;

    public virtual EmirateDim? ServiceDeliveryDistinationEmirate { get; set; }

    public virtual EmirateDim ServiceDeliveryLocationEmirate { get; set; } = null!;

    public virtual RoadAssistServicePriceByDistance? ServicePriceByDistance { get; set; }

    public virtual RoadAssistServicePriceByEmirate? ServicePriceByEmirate { get; set; }

    public virtual RoadAssistUserVehicle? UserVehicle { get; set; }
}
