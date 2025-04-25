using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RowStatusDim
{
    public int RowStatusId { get; set; }

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public DateTime VersionDateTime { get; set; }

    public virtual ICollection<AccidentTypeDim> AccidentTypeDims { get; set; } = new List<AccidentTypeDim>();

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityArea> ActivityAreas { get; set; } = new List<ActivityArea>();

    public virtual ICollection<ActivityAssociation> ActivityAssociations { get; set; } = new List<ActivityAssociation>();

    public virtual ICollection<ActivityCategoryDim> ActivityCategoryDims { get; set; } = new List<ActivityCategoryDim>();

    public virtual ICollection<ActivityComment> ActivityComments { get; set; } = new List<ActivityComment>();

    public virtual ICollection<ActivityContact> ActivityContacts { get; set; } = new List<ActivityContact>();

    public virtual ICollection<ActivityDocument> ActivityDocuments { get; set; } = new List<ActivityDocument>();

    public virtual ICollection<ActivityImage> ActivityImages { get; set; } = new List<ActivityImage>();

    public virtual ICollection<ActivityItemStatusDim> ActivityItemStatusDims { get; set; } = new List<ActivityItemStatusDim>();

    public virtual ICollection<ActivityItem> ActivityItems { get; set; } = new List<ActivityItem>();

    public virtual ICollection<ActivityLocation> ActivityLocations { get; set; } = new List<ActivityLocation>();

    public virtual ICollection<ActivityLog> ActivityLogs { get; set; } = new List<ActivityLog>();

    public virtual ICollection<ActivityOrganization> ActivityOrganizations { get; set; } = new List<ActivityOrganization>();

    public virtual ICollection<ActivityPerson> ActivityPeople { get; set; } = new List<ActivityPerson>();

    public virtual ICollection<ActivityReasonDim> ActivityReasonDims { get; set; } = new List<ActivityReasonDim>();

    public virtual ICollection<ActivityRelationshipCategoryDim> ActivityRelationshipCategoryDims { get; set; } = new List<ActivityRelationshipCategoryDim>();

    public virtual ICollection<ActivityRelationshipTypeDim> ActivityRelationshipTypeDims { get; set; } = new List<ActivityRelationshipTypeDim>();

    public virtual ICollection<ActivitySocialMedium> ActivitySocialMedia { get; set; } = new List<ActivitySocialMedium>();

    public virtual ICollection<ActivitySubscription> ActivitySubscriptions { get; set; } = new List<ActivitySubscription>();

    public virtual ICollection<AgencyCategoryDim> AgencyCategoryDims { get; set; } = new List<AgencyCategoryDim>();

    public virtual ICollection<AircraftCategoryDim> AircraftCategoryDims { get; set; } = new List<AircraftCategoryDim>();

    public virtual ICollection<AircraftUsageDim> AircraftUsageDims { get; set; } = new List<AircraftUsageDim>();

    public virtual ICollection<AlertAudienceDim> AlertAudienceDims { get; set; } = new List<AlertAudienceDim>();

    public virtual ICollection<AlertCategoryDim> AlertCategoryDims { get; set; } = new List<AlertCategoryDim>();

    public virtual ICollection<AlertCertaintyDim> AlertCertaintyDims { get; set; } = new List<AlertCertaintyDim>();

    public virtual ICollection<AlertEventDim> AlertEventDims { get; set; } = new List<AlertEventDim>();

    public virtual ICollection<AlertHandlingDim> AlertHandlingDims { get; set; } = new List<AlertHandlingDim>();

    public virtual ICollection<AlertInstructionDim> AlertInstructionDims { get; set; } = new List<AlertInstructionDim>();

    public virtual ICollection<AlertReasonDim> AlertReasonDims { get; set; } = new List<AlertReasonDim>();

    public virtual ICollection<AlertSenderDim> AlertSenderDims { get; set; } = new List<AlertSenderDim>();

    public virtual ICollection<AlertSeverityDim> AlertSeverityDims { get; set; } = new List<AlertSeverityDim>();

    public virtual ICollection<AlertTargetDim> AlertTargetDims { get; set; } = new List<AlertTargetDim>();

    public virtual ICollection<AlertUrgencyDim> AlertUrgencyDims { get; set; } = new List<AlertUrgencyDim>();

    public virtual ICollection<AreaAssociation> AreaAssociations { get; set; } = new List<AreaAssociation>();

    public virtual ICollection<AreaCategoryDim> AreaCategoryDims { get; set; } = new List<AreaCategoryDim>();

    public virtual ICollection<AreaInvolvementDim> AreaInvolvementDims { get; set; } = new List<AreaInvolvementDim>();

    public virtual ICollection<AreaRelationshipCategoryDim> AreaRelationshipCategoryDims { get; set; } = new List<AreaRelationshipCategoryDim>();

    public virtual ICollection<AreaRelationshipTypeDim> AreaRelationshipTypeDims { get; set; } = new List<AreaRelationshipTypeDim>();

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<ArrestCategoryDim> ArrestCategoryDims { get; set; } = new List<ArrestCategoryDim>();

    public virtual ICollection<ArrestCharge> ArrestCharges { get; set; } = new List<ArrestCharge>();

    public virtual ICollection<ArrestProbableCauseDim> ArrestProbableCauseDims { get; set; } = new List<ArrestProbableCauseDim>();

    public virtual ICollection<ArrestRightsReadResponseDim> ArrestRightsReadResponseDims { get; set; } = new List<ArrestRightsReadResponseDim>();

    public virtual ICollection<ArrestWarrant> ArrestWarrants { get; set; } = new List<ArrestWarrant>();

    public virtual ICollection<ArticleCategoryDim> ArticleCategoryDims { get; set; } = new List<ArticleCategoryDim>();

    public virtual ICollection<ArticleTypeDim> ArticleTypeDims { get; set; } = new List<ArticleTypeDim>();

    public virtual ICollection<AssessmentResponse> AssessmentResponses { get; set; } = new List<AssessmentResponse>();

    public virtual ICollection<AuditCategoryDim> AuditCategoryDims { get; set; } = new List<AuditCategoryDim>();

    public virtual ICollection<AuditDetail> AuditDetails { get; set; } = new List<AuditDetail>();

    public virtual ICollection<AuthorizationTypeDim> AuthorizationTypeDims { get; set; } = new List<AuthorizationTypeDim>();

    public virtual ICollection<BailConditionDim> BailConditionDims { get; set; } = new List<BailConditionDim>();

    public virtual ICollection<BailRequirementDim> BailRequirementDims { get; set; } = new List<BailRequirementDim>();

    public virtual ICollection<BoloCategoryDim> BoloCategoryDims { get; set; } = new List<BoloCategoryDim>();

    public virtual ICollection<BondConditionDim> BondConditionDims { get; set; } = new List<BondConditionDim>();

    public virtual ICollection<BondPaymentDim> BondPaymentDims { get; set; } = new List<BondPaymentDim>();

    public virtual ICollection<BondTerminationCategoryDim> BondTerminationCategoryDims { get; set; } = new List<BondTerminationCategoryDim>();

    public virtual ICollection<CareerDim> CareerDims { get; set; } = new List<CareerDim>();

    public virtual ICollection<CaseCategoryDim> CaseCategoryDims { get; set; } = new List<CaseCategoryDim>();

    public virtual ICollection<CaseCharge> CaseCharges { get; set; } = new List<CaseCharge>();

    public virtual ICollection<CaseExhibitEvidence> CaseExhibitEvidences { get; set; } = new List<CaseExhibitEvidence>();

    public virtual ICollection<CaseExhibitStatusDim> CaseExhibitStatusDims { get; set; } = new List<CaseExhibitStatusDim>();

    public virtual ICollection<CaseRestrictionDim> CaseRestrictionDims { get; set; } = new List<CaseRestrictionDim>();

    public virtual ICollection<CaseSecurityDim> CaseSecurityDims { get; set; } = new List<CaseSecurityDim>();

    public virtual ICollection<CaseSeverityDim> CaseSeverityDims { get; set; } = new List<CaseSeverityDim>();

    public virtual ICollection<CaseSolvabilityDim> CaseSolvabilityDims { get; set; } = new List<CaseSolvabilityDim>();

    public virtual ICollection<CaseStatusDim> CaseStatusDims { get; set; } = new List<CaseStatusDim>();

    public virtual ICollection<CaseTerminationCategoryDim> CaseTerminationCategoryDims { get; set; } = new List<CaseTerminationCategoryDim>();

    public virtual ICollection<CaseTerminationStageDim> CaseTerminationStageDims { get; set; } = new List<CaseTerminationStageDim>();

    public virtual ICollection<CautionInformationDim> CautionInformationDims { get; set; } = new List<CautionInformationDim>();

    public virtual ICollection<ChargeComment> ChargeComments { get; set; } = new List<ChargeComment>();

    public virtual ICollection<ChargeDegreeDim> ChargeDegreeDims { get; set; } = new List<ChargeDegreeDim>();

    public virtual ICollection<ChargeDisposition> ChargeDispositions { get; set; } = new List<ChargeDisposition>();

    public virtual ICollection<ChargeSeverityLevelDim> ChargeSeverityLevelDims { get; set; } = new List<ChargeSeverityLevelDim>();

    public virtual ICollection<ChargeStatusDim> ChargeStatusDims { get; set; } = new List<ChargeStatusDim>();

    public virtual ICollection<Charge> Charges { get; set; } = new List<Charge>();

    public virtual ICollection<ChemicalDim> ChemicalDims { get; set; } = new List<ChemicalDim>();

    public virtual ICollection<CitationDismissalConditionDim> CitationDismissalConditionDims { get; set; } = new List<CitationDismissalConditionDim>();

    public virtual ICollection<CitationStatusDim> CitationStatusDims { get; set; } = new List<CitationStatusDim>();

    public virtual ICollection<CitationViolation> CitationViolations { get; set; } = new List<CitationViolation>();

    public virtual ICollection<ClassificationDim> ClassificationDims { get; set; } = new List<ClassificationDim>();

    public virtual ICollection<CollisionDim> CollisionDims { get; set; } = new List<CollisionDim>();

    public virtual ICollection<ColorDim> ColorDims { get; set; } = new List<ColorDim>();

    public virtual ICollection<CommentCategoryDim> CommentCategoryDims { get; set; } = new List<CommentCategoryDim>();

    public virtual ICollection<CommentInvolvementDim> CommentInvolvementDims { get; set; } = new List<CommentInvolvementDim>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<CommunityServiceCategoryDim> CommunityServiceCategoryDims { get; set; } = new List<CommunityServiceCategoryDim>();

    public virtual ICollection<ConditionGroupDim> ConditionGroupDims { get; set; } = new List<ConditionGroupDim>();

    public virtual ICollection<ConditionViolationDim> ConditionViolationDims { get; set; } = new List<ConditionViolationDim>();

    public virtual ICollection<ConfiscationDocumentTypeDim> ConfiscationDocumentTypeDims { get; set; } = new List<ConfiscationDocumentTypeDim>();

    public virtual ICollection<ConfiscationLocationDim> ConfiscationLocationDims { get; set; } = new List<ConfiscationLocationDim>();

    public virtual ICollection<ContactCategoryDim> ContactCategoryDims { get; set; } = new List<ContactCategoryDim>();

    public virtual ICollection<ContactComment> ContactComments { get; set; } = new List<ContactComment>();

    public virtual ICollection<ContactInvolvementDim> ContactInvolvementDims { get; set; } = new List<ContactInvolvementDim>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<CounselingCategoryDim> CounselingCategoryDims { get; set; } = new List<CounselingCategoryDim>();

    public virtual ICollection<CourtActionCategoryDim> CourtActionCategoryDims { get; set; } = new List<CourtActionCategoryDim>();

    public virtual ICollection<CourtCategoryDim> CourtCategoryDims { get; set; } = new List<CourtCategoryDim>();

    public virtual ICollection<CourtEventCategoryDim> CourtEventCategoryDims { get; set; } = new List<CourtEventCategoryDim>();

    public virtual ICollection<CourtOrderCategoryDim> CourtOrderCategoryDims { get; set; } = new List<CourtOrderCategoryDim>();

    public virtual ICollection<CourtOrderProtectionConditionDim> CourtOrderProtectionConditionDims { get; set; } = new List<CourtOrderProtectionConditionDim>();

    public virtual ICollection<CourtOrderRecallReasonDim> CourtOrderRecallReasonDims { get; set; } = new List<CourtOrderRecallReasonDim>();

    public virtual ICollection<CourtOrderServiceCautionDim> CourtOrderServiceCautionDims { get; set; } = new List<CourtOrderServiceCautionDim>();

    public virtual ICollection<CourtOrderSignatureMethodDim> CourtOrderSignatureMethodDims { get; set; } = new List<CourtOrderSignatureMethodDim>();

    public virtual ICollection<CourtOrderSpecialInstructionDim> CourtOrderSpecialInstructionDims { get; set; } = new List<CourtOrderSpecialInstructionDim>();

    public virtual ICollection<CourtOrderStatusDim> CourtOrderStatusDims { get; set; } = new List<CourtOrderStatusDim>();

    public virtual ICollection<CourtOrderWarrant> CourtOrderWarrants { get; set; } = new List<CourtOrderWarrant>();

    public virtual ICollection<CriminalInvolvementDim> CriminalInvolvementDims { get; set; } = new List<CriminalInvolvementDim>();

    public virtual ICollection<CriminalTraitActivityDim> CriminalTraitActivityDims { get; set; } = new List<CriminalTraitActivityDim>();

    public virtual ICollection<CriminalTraitColorDim> CriminalTraitColorDims { get; set; } = new List<CriminalTraitColorDim>();

    public virtual ICollection<CriminalTraitCommunicationDim> CriminalTraitCommunicationDims { get; set; } = new List<CriminalTraitCommunicationDim>();

    public virtual ICollection<CriminalTraitDim> CriminalTraitDims { get; set; } = new List<CriminalTraitDim>();

    public virtual ICollection<CriminalTraitDressDim> CriminalTraitDressDims { get; set; } = new List<CriminalTraitDressDim>();

    public virtual ICollection<CriminalTraitHandSignalDim> CriminalTraitHandSignalDims { get; set; } = new List<CriminalTraitHandSignalDim>();

    public virtual ICollection<CriminalTraitModusOperandiDim> CriminalTraitModusOperandiDims { get; set; } = new List<CriminalTraitModusOperandiDim>();

    public virtual ICollection<CriminalTraitTargetDim> CriminalTraitTargetDims { get; set; } = new List<CriminalTraitTargetDim>();

    public virtual ICollection<CustodyTransferActionDim> CustodyTransferActionDims { get; set; } = new List<CustodyTransferActionDim>();

    public virtual ICollection<CustomLookup> CustomLookups { get; set; } = new List<CustomLookup>();

    public virtual ICollection<DateDim> DateDims { get; set; } = new List<DateDim>();

    public virtual ICollection<DateTimeDim> DateTimeDims { get; set; } = new List<DateTimeDim>();

    public virtual ICollection<DentalCharacteristicDim> DentalCharacteristicDims { get; set; } = new List<DentalCharacteristicDim>();

    public virtual ICollection<DentalCharacteristicRestorationDim> DentalCharacteristicRestorationDims { get; set; } = new List<DentalCharacteristicRestorationDim>();

    public virtual ICollection<DentalStatusDim> DentalStatusDims { get; set; } = new List<DentalStatusDim>();

    public virtual ICollection<DentalToothPositionDim> DentalToothPositionDims { get; set; } = new List<DentalToothPositionDim>();

    public virtual ICollection<DispositionCategoryDim> DispositionCategoryDims { get; set; } = new List<DispositionCategoryDim>();

    public virtual ICollection<DispositionReasonDim> DispositionReasonDims { get; set; } = new List<DispositionReasonDim>();

    public virtual ICollection<DisseminationMethodDim> DisseminationMethodDims { get; set; } = new List<DisseminationMethodDim>();

    public virtual ICollection<DnacollectionStatusDim> DnacollectionStatusDims { get; set; } = new List<DnacollectionStatusDim>();

    public virtual ICollection<DocketCategoryDim> DocketCategoryDims { get; set; } = new List<DocketCategoryDim>();

    public virtual ICollection<DocumentCategoryDim> DocumentCategoryDims { get; set; } = new List<DocumentCategoryDim>();

    public virtual ICollection<DocumentFormatDim> DocumentFormatDims { get; set; } = new List<DocumentFormatDim>();

    public virtual ICollection<DocumentInvolvementDim> DocumentInvolvementDims { get; set; } = new List<DocumentInvolvementDim>();

    public virtual ICollection<DocumentStatusDim> DocumentStatusDims { get; set; } = new List<DocumentStatusDim>();

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<DriverDrinkingStatusDim> DriverDrinkingStatusDims { get; set; } = new List<DriverDrinkingStatusDim>();

    public virtual ICollection<DriverLicenseCivilianClassDim> DriverLicenseCivilianClassDims { get; set; } = new List<DriverLicenseCivilianClassDim>();

    public virtual ICollection<DriverLicenseCommericalClassDim> DriverLicenseCommericalClassDims { get; set; } = new List<DriverLicenseCommericalClassDim>();

    public virtual ICollection<DriverLicensePermitStatusDim> DriverLicensePermitStatusDims { get; set; } = new List<DriverLicensePermitStatusDim>();

    public virtual ICollection<DriverStatusDim> DriverStatusDims { get; set; } = new List<DriverStatusDim>();

    public virtual ICollection<DrivingAccidentSeverityDim> DrivingAccidentSeverityDims { get; set; } = new List<DrivingAccidentSeverityDim>();

    public virtual ICollection<DrivingCmvdim> DrivingCmvdims { get; set; } = new List<DrivingCmvdim>();

    public virtual ICollection<DrivingHazMatDim> DrivingHazMatDims { get; set; } = new List<DrivingHazMatDim>();

    public virtual ICollection<DrivingRoadCategoryDim> DrivingRoadCategoryDims { get; set; } = new List<DrivingRoadCategoryDim>();

    public virtual ICollection<DrivingRoadConditionDim> DrivingRoadConditionDims { get; set; } = new List<DrivingRoadConditionDim>();

    public virtual ICollection<DrivingTrafficConditionDim> DrivingTrafficConditionDims { get; set; } = new List<DrivingTrafficConditionDim>();

    public virtual ICollection<DrivingWeatherConditionDim> DrivingWeatherConditionDims { get; set; } = new List<DrivingWeatherConditionDim>();

    public virtual ICollection<DrugCategoryDim> DrugCategoryDims { get; set; } = new List<DrugCategoryDim>();

    public virtual ICollection<DrugCompositionDim> DrugCompositionDims { get; set; } = new List<DrugCompositionDim>();

    public virtual ICollection<DrugContainerDim> DrugContainerDims { get; set; } = new List<DrugContainerDim>();

    public virtual ICollection<DrugFoundDim> DrugFoundDims { get; set; } = new List<DrugFoundDim>();

    public virtual ICollection<DrugSubstanceFormDim> DrugSubstanceFormDims { get; set; } = new List<DrugSubstanceFormDim>();

    public virtual ICollection<EducationCategoryDim> EducationCategoryDims { get; set; } = new List<EducationCategoryDim>();

    public virtual ICollection<EducationDegreeDim> EducationDegreeDims { get; set; } = new List<EducationDegreeDim>();

    public virtual ICollection<EducationScheduleDayDim> EducationScheduleDayDims { get; set; } = new List<EducationScheduleDayDim>();

    public virtual ICollection<EducationSchedule> EducationSchedules { get; set; } = new List<EducationSchedule>();

    public virtual ICollection<EducationStatusDim> EducationStatusDims { get; set; } = new List<EducationStatusDim>();

    public virtual ICollection<EmploymentDepartmentDim> EmploymentDepartmentDims { get; set; } = new List<EmploymentDepartmentDim>();

    public virtual ICollection<EmploymentOccupationDim> EmploymentOccupationDims { get; set; } = new List<EmploymentOccupationDim>();

    public virtual ICollection<EmploymentPositionDim> EmploymentPositionDims { get; set; } = new List<EmploymentPositionDim>();

    public virtual ICollection<EmploymentRankDim> EmploymentRankDims { get; set; } = new List<EmploymentRankDim>();

    public virtual ICollection<EmploymentStatusDim> EmploymentStatusDims { get; set; } = new List<EmploymentStatusDim>();

    public virtual ICollection<EmploymentWorkShiftDim> EmploymentWorkShiftDims { get; set; } = new List<EmploymentWorkShiftDim>();

    public virtual ICollection<EnforcementOfficialAsnCategoryDim> EnforcementOfficialAsnCategoryDims { get; set; } = new List<EnforcementOfficialAsnCategoryDim>();

    public virtual ICollection<EnforcementOfficialCategoryDim> EnforcementOfficialCategoryDims { get; set; } = new List<EnforcementOfficialCategoryDim>();

    public virtual ICollection<Entity> Entities { get; set; } = new List<Entity>();

    public virtual ICollection<EscapedStatusDim> EscapedStatusDims { get; set; } = new List<EscapedStatusDim>();

    public virtual ICollection<EthnicityDim> EthnicityDims { get; set; } = new List<EthnicityDim>();

    public virtual ICollection<EventIncidentActionDim> EventIncidentActionDims { get; set; } = new List<EventIncidentActionDim>();

    public virtual ICollection<EventIncidentCriticalityLevelDim> EventIncidentCriticalityLevelDims { get; set; } = new List<EventIncidentCriticalityLevelDim>();

    public virtual ICollection<EventIncidentSubTypeDim> EventIncidentSubTypeDims { get; set; } = new List<EventIncidentSubTypeDim>();

    public virtual ICollection<EventIncidentTypeDim> EventIncidentTypeDims { get; set; } = new List<EventIncidentTypeDim>();

    public virtual ICollection<FacilityBedAssignmentDim> FacilityBedAssignmentDims { get; set; } = new List<FacilityBedAssignmentDim>();

    public virtual ICollection<FacilityCategoryDim> FacilityCategoryDims { get; set; } = new List<FacilityCategoryDim>();

    public virtual ICollection<FacilityMemberCategoryDim> FacilityMemberCategoryDims { get; set; } = new List<FacilityMemberCategoryDim>();

    public virtual ICollection<FacilitySecurityLevelDim> FacilitySecurityLevelDims { get; set; } = new List<FacilitySecurityLevelDim>();

    public virtual ICollection<FileCategoryDim> FileCategoryDims { get; set; } = new List<FileCategoryDim>();

    public virtual ICollection<File> Files { get; set; } = new List<File>();

    public virtual ICollection<FingerPrintPatternCategoryDim> FingerPrintPatternCategoryDims { get; set; } = new List<FingerPrintPatternCategoryDim>();

    public virtual ICollection<FingerPrintPatternClassificationDim> FingerPrintPatternClassificationDims { get; set; } = new List<FingerPrintPatternClassificationDim>();

    public virtual ICollection<FingerprintFingerDim> FingerprintFingerDims { get; set; } = new List<FingerprintFingerDim>();

    public virtual ICollection<FirearmActionCategoryDim> FirearmActionCategoryDims { get; set; } = new List<FirearmActionCategoryDim>();

    public virtual ICollection<FirearmCategoryDim> FirearmCategoryDims { get; set; } = new List<FirearmCategoryDim>();

    public virtual ICollection<FirearmFinishDim> FirearmFinishDims { get; set; } = new List<FirearmFinishDim>();

    public virtual ICollection<FirearmGageCaliberDim> FirearmGageCaliberDims { get; set; } = new List<FirearmGageCaliberDim>();

    public virtual ICollection<FirearmGripDim> FirearmGripDims { get; set; } = new List<FirearmGripDim>();

    public virtual ICollection<GenderDim> GenderDims { get; set; } = new List<GenderDim>();

    public virtual ICollection<GeoCensusTractDim> GeoCensusTractDims { get; set; } = new List<GeoCensusTractDim>();

    public virtual ICollection<GeoCityDim> GeoCityDims { get; set; } = new List<GeoCityDim>();

    public virtual ICollection<GeoCountryDim> GeoCountryDims { get; set; } = new List<GeoCountryDim>();

    public virtual ICollection<GeoCountyDim> GeoCountyDims { get; set; } = new List<GeoCountyDim>();

    public virtual ICollection<GeoLeodim> GeoLeodims { get; set; } = new List<GeoLeodim>();

    public virtual ICollection<GeoLocationSubDivisionDim> GeoLocationSubDivisionDims { get; set; } = new List<GeoLocationSubDivisionDim>();

    public virtual ICollection<GeoStateDim> GeoStateDims { get; set; } = new List<GeoStateDim>();

    public virtual ICollection<GeoZipDim> GeoZipDims { get; set; } = new List<GeoZipDim>();

    public virtual ICollection<HeightMeasureUnitDim> HeightMeasureUnitDims { get; set; } = new List<HeightMeasureUnitDim>();

    public virtual ICollection<HighLowDim> HighLowDims { get; set; } = new List<HighLowDim>();

    public virtual ICollection<IdentificationAuthorityDim> IdentificationAuthorityDims { get; set; } = new List<IdentificationAuthorityDim>();

    public virtual ICollection<IdentificationCategoryDim> IdentificationCategoryDims { get; set; } = new List<IdentificationCategoryDim>();

    public virtual ICollection<IdentificationClassDim> IdentificationClassDims { get; set; } = new List<IdentificationClassDim>();

    public virtual ICollection<IdentificationRestrictionDim> IdentificationRestrictionDims { get; set; } = new List<IdentificationRestrictionDim>();

    public virtual ICollection<IdentificationtStatusDim> IdentificationtStatusDims { get; set; } = new List<IdentificationtStatusDim>();

    public virtual ICollection<IdentityTheftCategoryDim> IdentityTheftCategoryDims { get; set; } = new List<IdentityTheftCategoryDim>();

    public virtual ICollection<ImageCategoryDim> ImageCategoryDims { get; set; } = new List<ImageCategoryDim>();

    public virtual ICollection<ImageFormatDim> ImageFormatDims { get; set; } = new List<ImageFormatDim>();

    public virtual ICollection<ImageInvolvementDim> ImageInvolvementDims { get; set; } = new List<ImageInvolvementDim>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<ImpactLevelDim> ImpactLevelDims { get; set; } = new List<ImpactLevelDim>();

    public virtual ICollection<ImpactTypeDim> ImpactTypeDims { get; set; } = new List<ImpactTypeDim>();

    public virtual ICollection<IncidentActivityCategoryDim> IncidentActivityCategoryDims { get; set; } = new List<IncidentActivityCategoryDim>();

    public virtual ICollection<IncidentCategory> IncidentCategories { get; set; } = new List<IncidentCategory>();

    public virtual ICollection<IncidentCategoryStatus> IncidentCategoryStatuses { get; set; } = new List<IncidentCategoryStatus>();

    public virtual ICollection<IncidentExceptionalClearanceDim> IncidentExceptionalClearanceDims { get; set; } = new List<IncidentExceptionalClearanceDim>();

    public virtual ICollection<IncidentFactorDim> IncidentFactorDims { get; set; } = new List<IncidentFactorDim>();

    public virtual ICollection<IncidentFactor> IncidentFactors { get; set; } = new List<IncidentFactor>();

    public virtual ICollection<IncidentForceLevelDim> IncidentForceLevelDims { get; set; } = new List<IncidentForceLevelDim>();

    public virtual ICollection<IncidentLevelDim> IncidentLevelDims { get; set; } = new List<IncidentLevelDim>();

    public virtual ICollection<IncidentMethodDim> IncidentMethodDims { get; set; } = new List<IncidentMethodDim>();

    public virtual ICollection<IncidentStatute> IncidentStatutes { get; set; } = new List<IncidentStatute>();

    public virtual ICollection<InsuranceCompanyDim> InsuranceCompanyDims { get; set; } = new List<InsuranceCompanyDim>();

    public virtual ICollection<InsuranceTypeDim> InsuranceTypeDims { get; set; } = new List<InsuranceTypeDim>();

    public virtual ICollection<IntersectionDim> IntersectionDims { get; set; } = new List<IntersectionDim>();

    public virtual ICollection<IntoxicationIntoxicantCategoryDim> IntoxicationIntoxicantCategoryDims { get; set; } = new List<IntoxicationIntoxicantCategoryDim>();

    public virtual ICollection<IntoxicationLevelDim> IntoxicationLevelDims { get; set; } = new List<IntoxicationLevelDim>();

    public virtual ICollection<ItemAlias> ItemAliases { get; set; } = new List<ItemAlias>();

    public virtual ICollection<ItemCategoryDim> ItemCategoryDims { get; set; } = new List<ItemCategoryDim>();

    public virtual ICollection<ItemColorDim> ItemColorDims { get; set; } = new List<ItemColorDim>();

    public virtual ICollection<ItemComment> ItemComments { get; set; } = new List<ItemComment>();

    public virtual ICollection<ItemConditionDim> ItemConditionDims { get; set; } = new List<ItemConditionDim>();

    public virtual ICollection<ItemDocument> ItemDocuments { get; set; } = new List<ItemDocument>();

    public virtual ICollection<ItemIdentifierDistinctiveMarkingDim> ItemIdentifierDistinctiveMarkingDims { get; set; } = new List<ItemIdentifierDistinctiveMarkingDim>();

    public virtual ICollection<ItemIdentifierLocationDim> ItemIdentifierLocationDims { get; set; } = new List<ItemIdentifierLocationDim>();

    public virtual ICollection<ItemIdentifier> ItemIdentifiers { get; set; } = new List<ItemIdentifier>();

    public virtual ICollection<ItemImage> ItemImages { get; set; } = new List<ItemImage>();

    public virtual ICollection<ItemInvolvementDim> ItemInvolvementDims { get; set; } = new List<ItemInvolvementDim>();

    public virtual ICollection<ItemLocation> ItemLocations { get; set; } = new List<ItemLocation>();

    public virtual ICollection<ItemMakeModelDim> ItemMakeModelDims { get; set; } = new List<ItemMakeModelDim>();

    public virtual ICollection<ItemRegistrationAuthorityDim> ItemRegistrationAuthorityDims { get; set; } = new List<ItemRegistrationAuthorityDim>();

    public virtual ICollection<ItemRegistrationJurisdictionDim> ItemRegistrationJurisdictionDims { get; set; } = new List<ItemRegistrationJurisdictionDim>();

    public virtual ICollection<ItemRegistrationPlateCategoryDim> ItemRegistrationPlateCategoryDims { get; set; } = new List<ItemRegistrationPlateCategoryDim>();

    public virtual ICollection<ItemRegistrationPlateCodeDim> ItemRegistrationPlateCodeDims { get; set; } = new List<ItemRegistrationPlateCodeDim>();

    public virtual ICollection<ItemRegistrationPlateColorDim> ItemRegistrationPlateColorDims { get; set; } = new List<ItemRegistrationPlateColorDim>();

    public virtual ICollection<ItemRegistrationPlateKindDim> ItemRegistrationPlateKindDims { get; set; } = new List<ItemRegistrationPlateKindDim>();

    public virtual ICollection<ItemRegistration> ItemRegistrations { get; set; } = new List<ItemRegistration>();

    public virtual ICollection<ItemStatusDim> ItemStatusDims { get; set; } = new List<ItemStatusDim>();

    public virtual ICollection<ItemUsageDim> ItemUsageDims { get; set; } = new List<ItemUsageDim>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<JewelryCaratDim> JewelryCaratDims { get; set; } = new List<JewelryCaratDim>();

    public virtual ICollection<JewelryCategoryDim> JewelryCategoryDims { get; set; } = new List<JewelryCategoryDim>();

    public virtual ICollection<JewelryGenderDim> JewelryGenderDims { get; set; } = new List<JewelryGenderDim>();

    public virtual ICollection<JewelryMetalTypeDim> JewelryMetalTypeDims { get; set; } = new List<JewelryMetalTypeDim>();

    public virtual ICollection<JewelryStoneCaratDim> JewelryStoneCaratDims { get; set; } = new List<JewelryStoneCaratDim>();

    public virtual ICollection<JewelryStoneCategoryDim> JewelryStoneCategoryDims { get; set; } = new List<JewelryStoneCategoryDim>();

    public virtual ICollection<JewelryStoneCutDim> JewelryStoneCutDims { get; set; } = new List<JewelryStoneCutDim>();

    public virtual ICollection<JewelryStone> JewelryStones { get; set; } = new List<JewelryStone>();

    public virtual ICollection<JewelryStyleDim> JewelryStyleDims { get; set; } = new List<JewelryStyleDim>();

    public virtual ICollection<JudicialOfficialBarStatusDim> JudicialOfficialBarStatusDims { get; set; } = new List<JudicialOfficialBarStatusDim>();

    public virtual ICollection<JudicialOfficialCategoryDim> JudicialOfficialCategoryDims { get; set; } = new List<JudicialOfficialCategoryDim>();

    public virtual ICollection<JudicialOfficialPanelDim> JudicialOfficialPanelDims { get; set; } = new List<JudicialOfficialPanelDim>();

    public virtual ICollection<JurorDismissedReasonDim> JurorDismissedReasonDims { get; set; } = new List<JurorDismissedReasonDim>();

    public virtual ICollection<LanguageDim> LanguageDims { get; set; } = new List<LanguageDim>();

    public virtual ICollection<LicenseCategoryDim> LicenseCategoryDims { get; set; } = new List<LicenseCategoryDim>();

    public virtual ICollection<LicensePlateCameraDim> LicensePlateCameraDims { get; set; } = new List<LicensePlateCameraDim>();

    public virtual ICollection<LicensePlateDirectionDim> LicensePlateDirectionDims { get; set; } = new List<LicensePlateDirectionDim>();

    public virtual ICollection<LicensePlateLaneDim> LicensePlateLaneDims { get; set; } = new List<LicensePlateLaneDim>();

    public virtual ICollection<LicensePlateListSourceDim> LicensePlateListSourceDims { get; set; } = new List<LicensePlateListSourceDim>();

    public virtual ICollection<LicensePlateListTypeDim> LicensePlateListTypeDims { get; set; } = new List<LicensePlateListTypeDim>();

    public virtual ICollection<LicensePlateViolationTypeDim> LicensePlateViolationTypeDims { get; set; } = new List<LicensePlateViolationTypeDim>();

    public virtual ICollection<LocationArea> LocationAreas { get; set; } = new List<LocationArea>();

    public virtual ICollection<LocationCategoryDim> LocationCategoryDims { get; set; } = new List<LocationCategoryDim>();

    public virtual ICollection<LocationComment> LocationComments { get; set; } = new List<LocationComment>();

    public virtual ICollection<LocationContact> LocationContacts { get; set; } = new List<LocationContact>();

    public virtual ICollection<LocationDatumDim> LocationDatumDims { get; set; } = new List<LocationDatumDim>();

    public virtual ICollection<LocationDocument> LocationDocuments { get; set; } = new List<LocationDocument>();

    public virtual ICollection<LocationImage> LocationImages { get; set; } = new List<LocationImage>();

    public virtual ICollection<LocationInvolvementDim> LocationInvolvementDims { get; set; } = new List<LocationInvolvementDim>();

    public virtual ICollection<LocationStreetCategoryDim> LocationStreetCategoryDims { get; set; } = new List<LocationStreetCategoryDim>();

    public virtual ICollection<LocationStreetDirectionDim> LocationStreetDirectionDims { get; set; } = new List<LocationStreetDirectionDim>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<MeasureUnitDim> MeasureUnitDims { get; set; } = new List<MeasureUnitDim>();

    public virtual ICollection<MilitaryBranchDim> MilitaryBranchDims { get; set; } = new List<MilitaryBranchDim>();

    public virtual ICollection<MilitaryDischargeTypeDim> MilitaryDischargeTypeDims { get; set; } = new List<MilitaryDischargeTypeDim>();

    public virtual ICollection<MilitaryServiceTypeDim> MilitaryServiceTypeDims { get; set; } = new List<MilitaryServiceTypeDim>();

    public virtual ICollection<MilitaryStatusDim> MilitaryStatusDims { get; set; } = new List<MilitaryStatusDim>();

    public virtual ICollection<MissingPersonCategoryDim> MissingPersonCategoryDims { get; set; } = new List<MissingPersonCategoryDim>();

    public virtual ICollection<MissingPersonCircumstanceDim> MissingPersonCircumstanceDims { get; set; } = new List<MissingPersonCircumstanceDim>();

    public virtual ICollection<MissingPersonStatusDim> MissingPersonStatusDims { get; set; } = new List<MissingPersonStatusDim>();

    public virtual ICollection<MultiSourceOffenderDim> MultiSourceOffenderDims { get; set; } = new List<MultiSourceOffenderDim>();

    public virtual ICollection<NationalityDim> NationalityDims { get; set; } = new List<NationalityDim>();

    public virtual ICollection<OffenseChargeAssociation> OffenseChargeAssociations { get; set; } = new List<OffenseChargeAssociation>();

    public virtual ICollection<OffenseCitationAssociation> OffenseCitationAssociations { get; set; } = new List<OffenseCitationAssociation>();

    public virtual ICollection<OffenseCodeDim> OffenseCodeDims { get; set; } = new List<OffenseCodeDim>();

    public virtual ICollection<OffenseComment> OffenseComments { get; set; } = new List<OffenseComment>();

    public virtual ICollection<OffenseIncidentAssociation> OffenseIncidentAssociations { get; set; } = new List<OffenseIncidentAssociation>();

    public virtual ICollection<Offense> Offenses { get; set; } = new List<Offense>();

    public virtual ICollection<OfficerActivityDim> OfficerActivityDims { get; set; } = new List<OfficerActivityDim>();

    public virtual ICollection<OfficerAssignmentDim> OfficerAssignmentDims { get; set; } = new List<OfficerAssignmentDim>();

    public virtual ICollection<OfficerInjuryListDim> OfficerInjuryListDims { get; set; } = new List<OfficerInjuryListDim>();

    public virtual ICollection<OfficerMeansOfAttackDim> OfficerMeansOfAttackDims { get; set; } = new List<OfficerMeansOfAttackDim>();

    public virtual ICollection<OrganizationAssociationCategoryDim> OrganizationAssociationCategoryDims { get; set; } = new List<OrganizationAssociationCategoryDim>();

    public virtual ICollection<OrganizationAssociation> OrganizationAssociations { get; set; } = new List<OrganizationAssociation>();

    public virtual ICollection<OrganizationCategoryDim> OrganizationCategoryDims { get; set; } = new List<OrganizationCategoryDim>();

    public virtual ICollection<OrganizationComment> OrganizationComments { get; set; } = new List<OrganizationComment>();

    public virtual ICollection<OrganizationContact> OrganizationContacts { get; set; } = new List<OrganizationContact>();

    public virtual ICollection<OrganizationDocument> OrganizationDocuments { get; set; } = new List<OrganizationDocument>();

    public virtual ICollection<OrganizationImage> OrganizationImages { get; set; } = new List<OrganizationImage>();

    public virtual ICollection<OrganizationInvolvementDim> OrganizationInvolvementDims { get; set; } = new List<OrganizationInvolvementDim>();

    public virtual ICollection<OrganizationItemStatusDim> OrganizationItemStatusDims { get; set; } = new List<OrganizationItemStatusDim>();

    public virtual ICollection<OrganizationItem> OrganizationItems { get; set; } = new List<OrganizationItem>();

    public virtual ICollection<OrganizationLocation> OrganizationLocations { get; set; } = new List<OrganizationLocation>();

    public virtual ICollection<OrganizationLogCategoryDim> OrganizationLogCategoryDims { get; set; } = new List<OrganizationLogCategoryDim>();

    public virtual ICollection<OrganizationPerson> OrganizationPeople { get; set; } = new List<OrganizationPerson>();

    public virtual ICollection<OrganizationPersonnelCategoryDim> OrganizationPersonnelCategoryDims { get; set; } = new List<OrganizationPersonnelCategoryDim>();

    public virtual ICollection<OrganizationPersonnelRoleDim> OrganizationPersonnelRoleDims { get; set; } = new List<OrganizationPersonnelRoleDim>();

    public virtual ICollection<OrganizationReason> OrganizationReasons { get; set; } = new List<OrganizationReason>();

    public virtual ICollection<OrganizationSocialMedium> OrganizationSocialMedia { get; set; } = new List<OrganizationSocialMedium>();

    public virtual ICollection<OrganizationStatusDim> OrganizationStatusDims { get; set; } = new List<OrganizationStatusDim>();

    public virtual ICollection<OrganizationUnitCategoryDim> OrganizationUnitCategoryDims { get; set; } = new List<OrganizationUnitCategoryDim>();

    public virtual ICollection<OrganizationUnitLog> OrganizationUnitLogs { get; set; } = new List<OrganizationUnitLog>();

    public virtual ICollection<OrganizationUnitPersonnel> OrganizationUnitPersonnel { get; set; } = new List<OrganizationUnitPersonnel>();

    public virtual ICollection<OrganizationUnitStatusDim> OrganizationUnitStatusDims { get; set; } = new List<OrganizationUnitStatusDim>();

    public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; } = new List<OrganizationUnit>();

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();

    public virtual ICollection<PassagePointTypeDim> PassagePointTypeDims { get; set; } = new List<PassagePointTypeDim>();

    public virtual ICollection<Person> People { get; set; } = new List<Person>();

    public virtual ICollection<PersonAffiliation> PersonAffiliations { get; set; } = new List<PersonAffiliation>();

    public virtual ICollection<PersonAlias> PersonAliases { get; set; } = new List<PersonAlias>();

    public virtual ICollection<PersonBloodTypeDim> PersonBloodTypeDims { get; set; } = new List<PersonBloodTypeDim>();

    public virtual ICollection<PersonBodyPartStatusDim> PersonBodyPartStatusDims { get; set; } = new List<PersonBodyPartStatusDim>();

    public virtual ICollection<PersonBodyXrayDim> PersonBodyXrayDims { get; set; } = new List<PersonBodyXrayDim>();

    public virtual ICollection<PersonBuildDim> PersonBuildDims { get; set; } = new List<PersonBuildDim>();

    public virtual ICollection<PersonCategoryDim> PersonCategoryDims { get; set; } = new List<PersonCategoryDim>();

    public virtual ICollection<PersonCauseofDeathDim> PersonCauseofDeathDims { get; set; } = new List<PersonCauseofDeathDim>();

    public virtual ICollection<PersonCircumcisionDim> PersonCircumcisionDims { get; set; } = new List<PersonCircumcisionDim>();

    public virtual ICollection<PersonCitizenship> PersonCitizenships { get; set; } = new List<PersonCitizenship>();

    public virtual ICollection<PersonClothingCategoryDim> PersonClothingCategoryDims { get; set; } = new List<PersonClothingCategoryDim>();

    public virtual ICollection<PersonClothingColorDim> PersonClothingColorDims { get; set; } = new List<PersonClothingColorDim>();

    public virtual ICollection<PersonClothingStyleDim> PersonClothingStyleDims { get; set; } = new List<PersonClothingStyleDim>();

    public virtual ICollection<PersonClothing> PersonClothings { get; set; } = new List<PersonClothing>();

    public virtual ICollection<PersonCommentNew01> PersonCommentNew01s { get; set; } = new List<PersonCommentNew01>();

    public virtual ICollection<PersonComment> PersonComments { get; set; } = new List<PersonComment>();

    public virtual ICollection<PersonComplexionDim> PersonComplexionDims { get; set; } = new List<PersonComplexionDim>();

    public virtual ICollection<PersonContact> PersonContacts { get; set; } = new List<PersonContact>();

    public virtual ICollection<PersonDisguiseDim> PersonDisguiseDims { get; set; } = new List<PersonDisguiseDim>();

    public virtual ICollection<PersonDocument> PersonDocuments { get; set; } = new List<PersonDocument>();

    public virtual ICollection<PersonDriverLicense> PersonDriverLicenses { get; set; } = new List<PersonDriverLicense>();

    public virtual ICollection<PersonDrivingInsCoverageCategoryDim> PersonDrivingInsCoverageCategoryDims { get; set; } = new List<PersonDrivingInsCoverageCategoryDim>();

    public virtual ICollection<PersonDrivingInsuranceStatusDim> PersonDrivingInsuranceStatusDims { get; set; } = new List<PersonDrivingInsuranceStatusDim>();

    public virtual ICollection<PersonEducation> PersonEducations { get; set; } = new List<PersonEducation>();

    public virtual ICollection<PersonEmployment> PersonEmployments { get; set; } = new List<PersonEmployment>();

    public virtual ICollection<PersonEyeColorDim> PersonEyeColorDims { get; set; } = new List<PersonEyeColorDim>();

    public virtual ICollection<PersonEyeWearDim> PersonEyeWearDims { get; set; } = new List<PersonEyeWearDim>();

    public virtual ICollection<PersonFacialHairDim> PersonFacialHairDims { get; set; } = new List<PersonFacialHairDim>();

    public virtual ICollection<PersonFingerprintSet> PersonFingerprintSets { get; set; } = new List<PersonFingerprintSet>();

    public virtual ICollection<PersonGeneralAppearanceDim> PersonGeneralAppearanceDims { get; set; } = new List<PersonGeneralAppearanceDim>();

    public virtual ICollection<PersonHairAppearanceDim> PersonHairAppearanceDims { get; set; } = new List<PersonHairAppearanceDim>();

    public virtual ICollection<PersonHairColorDim> PersonHairColorDims { get; set; } = new List<PersonHairColorDim>();

    public virtual ICollection<PersonHairStyleDim> PersonHairStyleDims { get; set; } = new List<PersonHairStyleDim>();

    public virtual ICollection<PersonHandednessDim> PersonHandednessDims { get; set; } = new List<PersonHandednessDim>();

    public virtual ICollection<PersonImage> PersonImages { get; set; } = new List<PersonImage>();

    public virtual ICollection<PersonInjury> PersonInjuries { get; set; } = new List<PersonInjury>();

    public virtual ICollection<PersonInjuryLevelDim> PersonInjuryLevelDims { get; set; } = new List<PersonInjuryLevelDim>();

    public virtual ICollection<PersonInjuryListDim> PersonInjuryListDims { get; set; } = new List<PersonInjuryListDim>();

    public virtual ICollection<PersonIntoxication> PersonIntoxications { get; set; } = new List<PersonIntoxication>();

    public virtual ICollection<PersonInvolvementDim> PersonInvolvementDims { get; set; } = new List<PersonInvolvementDim>();

    public virtual ICollection<PersonItem> PersonItems { get; set; } = new List<PersonItem>();

    public virtual ICollection<PersonJewelryDim> PersonJewelryDims { get; set; } = new List<PersonJewelryDim>();

    public virtual ICollection<PersonLanguage> PersonLanguages { get; set; } = new List<PersonLanguage>();

    public virtual ICollection<PersonLocation> PersonLocations { get; set; } = new List<PersonLocation>();

    public virtual ICollection<PersonMaritalStatusDim> PersonMaritalStatusDims { get; set; } = new List<PersonMaritalStatusDim>();

    public virtual ICollection<PersonMedicalByDim> PersonMedicalByDims { get; set; } = new List<PersonMedicalByDim>();

    public virtual ICollection<PersonMedicalCautionDim> PersonMedicalCautionDims { get; set; } = new List<PersonMedicalCautionDim>();

    public virtual ICollection<PersonMedicalConditionTypeDim> PersonMedicalConditionTypeDims { get; set; } = new List<PersonMedicalConditionTypeDim>();

    public virtual ICollection<PersonMedicalCondition> PersonMedicalConditions { get; set; } = new List<PersonMedicalCondition>();

    public virtual ICollection<PersonMedicationDim> PersonMedicationDims { get; set; } = new List<PersonMedicationDim>();

    public virtual ICollection<PersonMilitarySummary> PersonMilitarySummaries { get; set; } = new List<PersonMilitarySummary>();

    public virtual ICollection<PersonMoruaryDim> PersonMoruaryDims { get; set; } = new List<PersonMoruaryDim>();

    public virtual ICollection<PersonNameCategoryDim> PersonNameCategoryDims { get; set; } = new List<PersonNameCategoryDim>();

    public virtual ICollection<PersonOtherIdentification> PersonOtherIdentifications { get; set; } = new List<PersonOtherIdentification>();

    public virtual ICollection<PersonPhysicalDetail> PersonPhysicalDetails { get; set; } = new List<PersonPhysicalDetail>();

    public virtual ICollection<PersonPhysicalFeature> PersonPhysicalFeatures { get; set; } = new List<PersonPhysicalFeature>();

    public virtual ICollection<PersonPhysicianDim> PersonPhysicianDims { get; set; } = new List<PersonPhysicianDim>();

    public virtual ICollection<PersonRaceDim> PersonRaceDims { get; set; } = new List<PersonRaceDim>();

    public virtual ICollection<PersonRelationshipTypeDim> PersonRelationshipTypeDims { get; set; } = new List<PersonRelationshipTypeDim>();

    public virtual ICollection<PersonRelationship> PersonRelationships { get; set; } = new List<PersonRelationship>();

    public virtual ICollection<PersonReligionDim> PersonReligionDims { get; set; } = new List<PersonReligionDim>();

    public virtual ICollection<PersonSexDim> PersonSexDims { get; set; } = new List<PersonSexDim>();

    public virtual ICollection<PersonSexualOrientationDim> PersonSexualOrientationDims { get; set; } = new List<PersonSexualOrientationDim>();

    public virtual ICollection<PersonSkinToneDim> PersonSkinToneDims { get; set; } = new List<PersonSkinToneDim>();

    public virtual ICollection<PersonSocialMedium> PersonSocialMedia { get; set; } = new List<PersonSocialMedium>();

    public virtual ICollection<PersonSpeechDim> PersonSpeechDims { get; set; } = new List<PersonSpeechDim>();

    public virtual ICollection<PersonStatusDim> PersonStatusDims { get; set; } = new List<PersonStatusDim>();

    public virtual ICollection<PersonTooth> PersonTeeth { get; set; } = new List<PersonTooth>();

    public virtual ICollection<PersonTransportedByDim> PersonTransportedByDims { get; set; } = new List<PersonTransportedByDim>();

    public virtual ICollection<PersonVitalStatistic> PersonVitalStatistics { get; set; } = new List<PersonVitalStatistic>();

    public virtual ICollection<PhysicalAppearanceHistory> PhysicalAppearanceHistories { get; set; } = new List<PhysicalAppearanceHistory>();

    public virtual ICollection<PhysicalFeatureCategoryDim> PhysicalFeatureCategoryDims { get; set; } = new List<PhysicalFeatureCategoryDim>();

    public virtual ICollection<PhysicalFeatureHandicapDim> PhysicalFeatureHandicapDims { get; set; } = new List<PhysicalFeatureHandicapDim>();

    public virtual ICollection<PhysicalFeatureLocationDim> PhysicalFeatureLocationDims { get; set; } = new List<PhysicalFeatureLocationDim>();

    public virtual ICollection<PhysicalFeatureSeverityDim> PhysicalFeatureSeverityDims { get; set; } = new List<PhysicalFeatureSeverityDim>();

    public virtual ICollection<PlateSourceDim> PlateSourceDims { get; set; } = new List<PlateSourceDim>();

    public virtual ICollection<PolicyDim> PolicyDims { get; set; } = new List<PolicyDim>();

    public virtual ICollection<ProgramDim> ProgramDims { get; set; } = new List<ProgramDim>();

    public virtual ICollection<ProgramReferralStatusDim> ProgramReferralStatusDims { get; set; } = new List<ProgramReferralStatusDim>();

    public virtual ICollection<ProgramStatusDim> ProgramStatusDims { get; set; } = new List<ProgramStatusDim>();

    public virtual ICollection<PropertyTypeDim> PropertyTypeDims { get; set; } = new List<PropertyTypeDim>();

    public virtual ICollection<ProviderCategoryDim> ProviderCategoryDims { get; set; } = new List<ProviderCategoryDim>();

    public virtual ICollection<ProviderStatusDim> ProviderStatusDims { get; set; } = new List<ProviderStatusDim>();

    public virtual ICollection<QuestionCategoryDim> QuestionCategoryDims { get; set; } = new List<QuestionCategoryDim>();

    public virtual ICollection<QuestionChoice> QuestionChoices { get; set; } = new List<QuestionChoice>();

    public virtual ICollection<QuestionnaireCategoryDim> QuestionnaireCategoryDims { get; set; } = new List<QuestionnaireCategoryDim>();

    public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; } = new List<QuestionnaireQuestion>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<RealestateAttachedFacilityDim> RealestateAttachedFacilityDims { get; set; } = new List<RealestateAttachedFacilityDim>();

    public virtual ICollection<RealestateCategoryDim> RealestateCategoryDims { get; set; } = new List<RealestateCategoryDim>();

    public virtual ICollection<RegisterofActionCategoryDim> RegisterofActionCategoryDims { get; set; } = new List<RegisterofActionCategoryDim>();

    public virtual ICollection<ReleaseAuthorizationCategoryDim> ReleaseAuthorizationCategoryDims { get; set; } = new List<ReleaseAuthorizationCategoryDim>();

    public virtual ICollection<ReleaseReasonDim> ReleaseReasonDims { get; set; } = new List<ReleaseReasonDim>();

    public virtual ICollection<ReportStatusDim> ReportStatusDims { get; set; } = new List<ReportStatusDim>();

    public virtual ICollection<ReportTypeDim> ReportTypeDims { get; set; } = new List<ReportTypeDim>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<RequestCategoryDim> RequestCategoryDims { get; set; } = new List<RequestCategoryDim>();

    public virtual ICollection<RequestCheckCategoryDim> RequestCheckCategoryDims { get; set; } = new List<RequestCheckCategoryDim>();

    public virtual ICollection<RequestCheck> RequestChecks { get; set; } = new List<RequestCheck>();

    public virtual ICollection<RequestInputMethodDim> RequestInputMethodDims { get; set; } = new List<RequestInputMethodDim>();

    public virtual ICollection<RequestOffenseCategoryDim> RequestOffenseCategoryDims { get; set; } = new List<RequestOffenseCategoryDim>();

    public virtual ICollection<RequestOffense> RequestOffenses { get; set; } = new List<RequestOffense>();

    public virtual ICollection<RequestServiceCategoryDim> RequestServiceCategoryDims { get; set; } = new List<RequestServiceCategoryDim>();

    public virtual ICollection<RequestService> RequestServices { get; set; } = new List<RequestService>();

    public virtual ICollection<RequestViolationCategoryDim> RequestViolationCategoryDims { get; set; } = new List<RequestViolationCategoryDim>();

    public virtual ICollection<RequestViolation> RequestViolations { get; set; } = new List<RequestViolation>();

    public virtual ICollection<RoadSpeedDim> RoadSpeedDims { get; set; } = new List<RoadSpeedDim>();

    public virtual ICollection<RoadSurfaceDim> RoadSurfaceDims { get; set; } = new List<RoadSurfaceDim>();

    public virtual ICollection<SearchCategoryDim> SearchCategoryDims { get; set; } = new List<SearchCategoryDim>();

    public virtual ICollection<SearchCompareDim> SearchCompareDims { get; set; } = new List<SearchCompareDim>();

    public virtual ICollection<SearchDataTypeDim> SearchDataTypeDims { get; set; } = new List<SearchDataTypeDim>();

    public virtual ICollection<SearchDetail> SearchDetails { get; set; } = new List<SearchDetail>();

    public virtual ICollection<SearchParameterDim> SearchParameterDims { get; set; } = new List<SearchParameterDim>();

    public virtual ICollection<SearchResponseStatusDim> SearchResponseStatusDims { get; set; } = new List<SearchResponseStatusDim>();

    public virtual ICollection<SentenceGroupingDim> SentenceGroupingDims { get; set; } = new List<SentenceGroupingDim>();

    public virtual ICollection<ServiceCallCategoryDim> ServiceCallCategoryDims { get; set; } = new List<ServiceCallCategoryDim>();

    public virtual ICollection<ServiceCallClearanceDim> ServiceCallClearanceDims { get; set; } = new List<ServiceCallClearanceDim>();

    public virtual ICollection<ServiceCallDispositionDim> ServiceCallDispositionDims { get; set; } = new List<ServiceCallDispositionDim>();

    public virtual ICollection<ServiceCallMechanismDim> ServiceCallMechanismDims { get; set; } = new List<ServiceCallMechanismDim>();

    public virtual ICollection<ServiceCallPriorityDim> ServiceCallPriorityDims { get; set; } = new List<ServiceCallPriorityDim>();

    public virtual ICollection<ServiceCallSourceDim> ServiceCallSourceDims { get; set; } = new List<ServiceCallSourceDim>();

    public virtual ICollection<ServiceClassDim> ServiceClassDims { get; set; } = new List<ServiceClassDim>();

    public virtual ICollection<SocialMedium> SocialMedia { get; set; } = new List<SocialMedium>();

    public virtual ICollection<SocialMediaAuthorization> SocialMediaAuthorizations { get; set; } = new List<SocialMediaAuthorization>();

    public virtual ICollection<SocialMediaCategoryDim> SocialMediaCategoryDims { get; set; } = new List<SocialMediaCategoryDim>();

    public virtual ICollection<SocialMediaComment> SocialMediaComments { get; set; } = new List<SocialMediaComment>();

    public virtual ICollection<SocialMediaInvolvementDim> SocialMediaInvolvementDims { get; set; } = new List<SocialMediaInvolvementDim>();

    public virtual ICollection<SocialMediaLocation> SocialMediaLocations { get; set; } = new List<SocialMediaLocation>();

    public virtual ICollection<SocialMediaPerson> SocialMediaPeople { get; set; } = new List<SocialMediaPerson>();

    public virtual ICollection<SourceCategoryDim> SourceCategoryDims { get; set; } = new List<SourceCategoryDim>();

    public virtual ICollection<SourceDirectoryCategoryDim> SourceDirectoryCategoryDims { get; set; } = new List<SourceDirectoryCategoryDim>();

    public virtual ICollection<SourcePolicyDim> SourcePolicyDims { get; set; } = new List<SourcePolicyDim>();

    public virtual ICollection<Source> Sources { get; set; } = new List<Source>();

    public virtual ICollection<StatusDim> StatusDims { get; set; } = new List<StatusDim>();

    public virtual ICollection<Status> Statuses { get; set; } = new List<Status>();

    public virtual ICollection<StatuteDim> StatuteDims { get; set; } = new List<StatuteDim>();

    public virtual ICollection<StatuteSeverityDim> StatuteSeverityDims { get; set; } = new List<StatuteSeverityDim>();

    public virtual ICollection<SubjectDisciplinaryActionDim> SubjectDisciplinaryActionDims { get; set; } = new List<SubjectDisciplinaryActionDim>();

    public virtual ICollection<SubjectExtraditionDim> SubjectExtraditionDims { get; set; } = new List<SubjectExtraditionDim>();

    public virtual ICollection<SubjectRegistrationCategoryDim> SubjectRegistrationCategoryDims { get; set; } = new List<SubjectRegistrationCategoryDim>();

    public virtual ICollection<SubjectRegistration> SubjectRegistrations { get; set; } = new List<SubjectRegistration>();

    public virtual ICollection<SubjectStatusDim> SubjectStatusDims { get; set; } = new List<SubjectStatusDim>();

    public virtual ICollection<SubscriptionCategoryDim> SubscriptionCategoryDims { get; set; } = new List<SubscriptionCategoryDim>();

    public virtual ICollection<SubscriptionInvolvementDim> SubscriptionInvolvementDims { get; set; } = new List<SubscriptionInvolvementDim>();

    public virtual ICollection<SubscriptionLocation> SubscriptionLocations { get; set; } = new List<SubscriptionLocation>();

    public virtual ICollection<SubscriptionPolygonCategoryDim> SubscriptionPolygonCategoryDims { get; set; } = new List<SubscriptionPolygonCategoryDim>();

    public virtual ICollection<SubscriptionPolygon> SubscriptionPolygons { get; set; } = new List<SubscriptionPolygon>();

    public virtual ICollection<SubscriptionSocialMedium> SubscriptionSocialMedia { get; set; } = new List<SubscriptionSocialMedium>();

    public virtual ICollection<SubscriptionSubdivision> SubscriptionSubdivisions { get; set; } = new List<SubscriptionSubdivision>();

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();

    public virtual ICollection<SupervisionCategoryDim> SupervisionCategoryDims { get; set; } = new List<SupervisionCategoryDim>();

    public virtual ICollection<SupervisionCustodyStatusDim> SupervisionCustodyStatusDims { get; set; } = new List<SupervisionCustodyStatusDim>();

    public virtual ICollection<SupervisionStatusDim> SupervisionStatusDims { get; set; } = new List<SupervisionStatusDim>();

    public virtual ICollection<SupportAuditDim> SupportAuditDims { get; set; } = new List<SupportAuditDim>();

    public virtual ICollection<SupportSupportExceptionDimtableDescriptionCodeColumnDetail> SupportSupportExceptionDimtableDescriptionCodeColumnDetails { get; set; } = new List<SupportSupportExceptionDimtableDescriptionCodeColumnDetail>();

    public virtual ICollection<SupportTableSpsFunctionsAndView> SupportTableSpsFunctionsAndViews { get; set; } = new List<SupportTableSpsFunctionsAndView>();

    public virtual ICollection<SupportTablesAndRelation> SupportTablesAndRelations { get; set; } = new List<SupportTablesAndRelation>();

    public virtual ICollection<TheftCategoryDim> TheftCategoryDims { get; set; } = new List<TheftCategoryDim>();

    public virtual ICollection<TimeCategoryDim> TimeCategoryDims { get; set; } = new List<TimeCategoryDim>();

    public virtual ICollection<TimeDim> TimeDims { get; set; } = new List<TimeDim>();

    public virtual ICollection<TipLeadCategoryDim> TipLeadCategoryDims { get; set; } = new List<TipLeadCategoryDim>();

    public virtual ICollection<TipLeadContentValidityDim> TipLeadContentValidityDims { get; set; } = new List<TipLeadContentValidityDim>();

    public virtual ICollection<TipLeadOffense> TipLeadOffenses { get; set; } = new List<TipLeadOffense>();

    public virtual ICollection<TipLeadReliabilityDim> TipLeadReliabilityDims { get; set; } = new List<TipLeadReliabilityDim>();

    public virtual ICollection<TipLeadSourceCategoryDim> TipLeadSourceCategoryDims { get; set; } = new List<TipLeadSourceCategoryDim>();

    public virtual ICollection<TipLeadSourceMethodContactDim> TipLeadSourceMethodContactDims { get; set; } = new List<TipLeadSourceMethodContactDim>();

    public virtual ICollection<TrueFalseDim> TrueFalseDims { get; set; } = new List<TrueFalseDim>();

    public virtual ICollection<VehicleBrandDim> VehicleBrandDims { get; set; } = new List<VehicleBrandDim>();

    public virtual ICollection<VehicleCategoryDim> VehicleCategoryDims { get; set; } = new List<VehicleCategoryDim>();

    public virtual ICollection<VehicleDataTypeDim> VehicleDataTypeDims { get; set; } = new List<VehicleDataTypeDim>();

    public virtual ICollection<VehicleModelDim> VehicleModelDims { get; set; } = new List<VehicleModelDim>();

    public virtual ICollection<VehicleStatusDim> VehicleStatusDims { get; set; } = new List<VehicleStatusDim>();

    public virtual ICollection<VehicleTypeDim> VehicleTypeDims { get; set; } = new List<VehicleTypeDim>();

    public virtual ICollection<VesselCategoryDim> VesselCategoryDims { get; set; } = new List<VesselCategoryDim>();

    public virtual ICollection<VesselHullMaterialDim> VesselHullMaterialDims { get; set; } = new List<VesselHullMaterialDim>();

    public virtual ICollection<VesselHullShapeDim> VesselHullShapeDims { get; set; } = new List<VesselHullShapeDim>();

    public virtual ICollection<VesselPropulsionTypeDim> VesselPropulsionTypeDims { get; set; } = new List<VesselPropulsionTypeDim>();

    public virtual ICollection<VictimCategoryDim> VictimCategoryDims { get; set; } = new List<VictimCategoryDim>();

    public virtual ICollection<VictimMeansOfAttackDim> VictimMeansOfAttackDims { get; set; } = new List<VictimMeansOfAttackDim>();

    public virtual ICollection<WarrantAppearanceBailForfeitDim> WarrantAppearanceBailForfeitDims { get; set; } = new List<WarrantAppearanceBailForfeitDim>();

    public virtual ICollection<WarrantAppearanceBail> WarrantAppearanceBails { get; set; } = new List<WarrantAppearanceBail>();

    public virtual ICollection<WarrantCategoryDim> WarrantCategoryDims { get; set; } = new List<WarrantCategoryDim>();

    public virtual ICollection<WarrantExtraditionLimitationDim> WarrantExtraditionLimitationDims { get; set; } = new List<WarrantExtraditionLimitationDim>();

    public virtual ICollection<WarrantFurtherProcessingDim> WarrantFurtherProcessingDims { get; set; } = new List<WarrantFurtherProcessingDim>();

    public virtual ICollection<WarrantLevelDim> WarrantLevelDims { get; set; } = new List<WarrantLevelDim>();

    public virtual ICollection<WarrantProbableCauseDim> WarrantProbableCauseDims { get; set; } = new List<WarrantProbableCauseDim>();

    public virtual ICollection<WeatherDim> WeatherDims { get; set; } = new List<WeatherDim>();

    public virtual ICollection<WeightMeasureUnitDim> WeightMeasureUnitDims { get; set; } = new List<WeightMeasureUnitDim>();

    public virtual ICollection<YearDim> YearDims { get; set; } = new List<YearDim>();
}
