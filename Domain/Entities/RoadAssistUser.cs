using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistUser
{
    public Guid UserId { get; set; }

    public long? ReferenceUserId { get; set; }

    public Guid? UserTypeId { get; set; }

    public virtual ICollection<RoadAssistActivityFlowMapping> RoadAssistActivityFlowMappingCreatedByUsers { get; set; } = new List<RoadAssistActivityFlowMapping>();

    public virtual ICollection<RoadAssistActivityFlowMapping> RoadAssistActivityFlowMappingLastModifiedByUsers { get; set; } = new List<RoadAssistActivityFlowMapping>();

    public virtual ICollection<RoadAssistFuelFeesPerUnit> RoadAssistFuelFeesPerUnitCreatedByUsers { get; set; } = new List<RoadAssistFuelFeesPerUnit>();

    public virtual ICollection<RoadAssistFuelFeesPerUnit> RoadAssistFuelFeesPerUnitLastModifiedByUsers { get; set; } = new List<RoadAssistFuelFeesPerUnit>();

    public virtual ICollection<RoadAssistFuelTypeDim> RoadAssistFuelTypeDimCreatedByUsers { get; set; } = new List<RoadAssistFuelTypeDim>();

    public virtual ICollection<RoadAssistFuelTypeDim> RoadAssistFuelTypeDimLastModifiedByUsers { get; set; } = new List<RoadAssistFuelTypeDim>();

    public virtual ICollection<RoadAssistIntegrationTokenLog> RoadAssistIntegrationTokenLogs { get; set; } = new List<RoadAssistIntegrationTokenLog>();

    public virtual ICollection<RoadAssistNotificationMessageConfig> RoadAssistNotificationMessageConfigCreatedByUsers { get; set; } = new List<RoadAssistNotificationMessageConfig>();

    public virtual ICollection<RoadAssistNotificationMessageConfig> RoadAssistNotificationMessageConfigLastModifiedByUsers { get; set; } = new List<RoadAssistNotificationMessageConfig>();

    public virtual ICollection<RoadAssistPaymentFee> RoadAssistPaymentFeeCreatedByUsers { get; set; } = new List<RoadAssistPaymentFee>();

    public virtual ICollection<RoadAssistPaymentFee> RoadAssistPaymentFeeLastModifiedByUsers { get; set; } = new List<RoadAssistPaymentFee>();

    public virtual ICollection<RoadAssistProviderBranch> RoadAssistProviderBranchCreatedByUsers { get; set; } = new List<RoadAssistProviderBranch>();

    public virtual ICollection<RoadAssistProviderBranch> RoadAssistProviderBranchLastModifiedByUsers { get; set; } = new List<RoadAssistProviderBranch>();

    public virtual ICollection<RoadAssistProvider> RoadAssistProviderCreatedByUsers { get; set; } = new List<RoadAssistProvider>();

    public virtual ICollection<RoadAssistProvider> RoadAssistProviderLastModifiedByUsers { get; set; } = new List<RoadAssistProvider>();

    public virtual ICollection<RoadAssistProviderService> RoadAssistProviderServiceCreatedByUsers { get; set; } = new List<RoadAssistProviderService>();

    public virtual ICollection<RoadAssistProviderService> RoadAssistProviderServiceLastModifiedByUsers { get; set; } = new List<RoadAssistProviderService>();

    public virtual ICollection<RoadAssistProviderVehicle> RoadAssistProviderVehicleCreatedByUsers { get; set; } = new List<RoadAssistProviderVehicle>();

    public virtual ICollection<RoadAssistProviderVehicle> RoadAssistProviderVehicleLastModifiedByUsers { get; set; } = new List<RoadAssistProviderVehicle>();

    public virtual ICollection<RoadAssistRequestActivityDim> RoadAssistRequestActivityDimCreatedByUsers { get; set; } = new List<RoadAssistRequestActivityDim>();

    public virtual ICollection<RoadAssistRequestActivityDim> RoadAssistRequestActivityDimLastModifiedByUsers { get; set; } = new List<RoadAssistRequestActivityDim>();

    public virtual ICollection<RoadAssistRequestComment> RoadAssistRequestCommentCreatedByUsers { get; set; } = new List<RoadAssistRequestComment>();

    public virtual ICollection<RoadAssistRequestComment> RoadAssistRequestCommentLastModifiedByUsers { get; set; } = new List<RoadAssistRequestComment>();

    public virtual ICollection<RoadAssistRequest> RoadAssistRequestCreatedByUsers { get; set; } = new List<RoadAssistRequest>();

    public virtual ICollection<RoadAssistRequestFee> RoadAssistRequestFeeCreatedByUsers { get; set; } = new List<RoadAssistRequestFee>();

    public virtual ICollection<RoadAssistRequestFee> RoadAssistRequestFeeLastModifiedByUsers { get; set; } = new List<RoadAssistRequestFee>();

    public virtual ICollection<RoadAssistRequestFeesTypeDim> RoadAssistRequestFeesTypeDimCreatedByUsers { get; set; } = new List<RoadAssistRequestFeesTypeDim>();

    public virtual ICollection<RoadAssistRequestFeesTypeDim> RoadAssistRequestFeesTypeDimLastModifiedByUsers { get; set; } = new List<RoadAssistRequestFeesTypeDim>();

    public virtual ICollection<RoadAssistRequest> RoadAssistRequestLastModifiedByUsers { get; set; } = new List<RoadAssistRequest>();

    public virtual ICollection<RoadAssistRequestRejectionReasonDim> RoadAssistRequestRejectionReasonDimCreatedByUsers { get; set; } = new List<RoadAssistRequestRejectionReasonDim>();

    public virtual ICollection<RoadAssistRequestRejectionReasonDim> RoadAssistRequestRejectionReasonDimLastModifiedByUsers { get; set; } = new List<RoadAssistRequestRejectionReasonDim>();

    public virtual ICollection<RoadAssistRequestStatusDim> RoadAssistRequestStatusDimCreatedByUsers { get; set; } = new List<RoadAssistRequestStatusDim>();

    public virtual ICollection<RoadAssistRequestStatusDim> RoadAssistRequestStatusDimLastModifiedByUsers { get; set; } = new List<RoadAssistRequestStatusDim>();

    public virtual ICollection<RoadAssistRequestStatusLog> RoadAssistRequestStatusLogCreatedByUsers { get; set; } = new List<RoadAssistRequestStatusLog>();

    public virtual ICollection<RoadAssistRequestStatusLog> RoadAssistRequestStatusLogLastModifiedByUsers { get; set; } = new List<RoadAssistRequestStatusLog>();

    public virtual ICollection<RoadAssistRider> RoadAssistRiderCreatedByUsers { get; set; } = new List<RoadAssistRider>();

    public virtual ICollection<RoadAssistRider> RoadAssistRiderLastModifiedByUsers { get; set; } = new List<RoadAssistRider>();

    public virtual ICollection<RoadAssistSaaedShareValue> RoadAssistSaaedShareValueCreatedByUsers { get; set; } = new List<RoadAssistSaaedShareValue>();

    public virtual ICollection<RoadAssistSaaedShareValue> RoadAssistSaaedShareValueLastModifiedByUsers { get; set; } = new List<RoadAssistSaaedShareValue>();

    public virtual ICollection<RoadAssistService> RoadAssistServiceCreatedByUsers { get; set; } = new List<RoadAssistService>();

    public virtual ICollection<RoadAssistService> RoadAssistServiceLastModifiedByUsers { get; set; } = new List<RoadAssistService>();

    public virtual ICollection<RoadAssistServicePriceByDistance> RoadAssistServicePriceByDistanceCreatedByUsers { get; set; } = new List<RoadAssistServicePriceByDistance>();

    public virtual ICollection<RoadAssistServicePriceByDistance> RoadAssistServicePriceByDistanceLastModifiedByUsers { get; set; } = new List<RoadAssistServicePriceByDistance>();

    public virtual ICollection<RoadAssistServicePriceByEmirate> RoadAssistServicePriceByEmirateCreatedByUsers { get; set; } = new List<RoadAssistServicePriceByEmirate>();

    public virtual ICollection<RoadAssistServicePriceByEmirate> RoadAssistServicePriceByEmirateLastModifiedByUsers { get; set; } = new List<RoadAssistServicePriceByEmirate>();

    public virtual ICollection<RoadAssistServiceStatusDim> RoadAssistServiceStatusDimCreatedByUsers { get; set; } = new List<RoadAssistServiceStatusDim>();

    public virtual ICollection<RoadAssistServiceStatusDim> RoadAssistServiceStatusDimLastModifiedByUsers { get; set; } = new List<RoadAssistServiceStatusDim>();

    public virtual ICollection<RoadAssistServiceStep> RoadAssistServiceStepCreatedByUsers { get; set; } = new List<RoadAssistServiceStep>();

    public virtual ICollection<RoadAssistServiceStep> RoadAssistServiceStepLastModifiedByUsers { get; set; } = new List<RoadAssistServiceStep>();

    public virtual ICollection<RoadAssistStatusFlowMapping> RoadAssistStatusFlowMappingCreatedByUsers { get; set; } = new List<RoadAssistStatusFlowMapping>();

    public virtual ICollection<RoadAssistStatusFlowMapping> RoadAssistStatusFlowMappingLastModifiedByUsers { get; set; } = new List<RoadAssistStatusFlowMapping>();

    public virtual ICollection<RoadAssistTax> RoadAssistTaxCreatedByUsers { get; set; } = new List<RoadAssistTax>();

    public virtual ICollection<RoadAssistTax> RoadAssistTaxLastModifiedByUsers { get; set; } = new List<RoadAssistTax>();

    public virtual ICollection<RoadAssistUserVehicle> RoadAssistUserVehicleCreatedByUsers { get; set; } = new List<RoadAssistUserVehicle>();

    public virtual ICollection<RoadAssistUserVehicle> RoadAssistUserVehicleLastModifiedByUsers { get; set; } = new List<RoadAssistUserVehicle>();

    public virtual ICollection<RoadAssistUserVehicle> RoadAssistUserVehicleUsers { get; set; } = new List<RoadAssistUserVehicle>();

    public virtual ICollection<RoadAssistVehicle> RoadAssistVehicleCreatedByUsers { get; set; } = new List<RoadAssistVehicle>();

    public virtual ICollection<RoadAssistVehicle> RoadAssistVehicleLastModifiedByUsers { get; set; } = new List<RoadAssistVehicle>();

    public virtual RoadAssistUserType? UserType { get; set; }
}
