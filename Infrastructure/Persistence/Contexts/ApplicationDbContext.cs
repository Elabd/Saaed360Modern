using Infrastructure.Persistence.Entities;
using Infrastructure.Persistence.ModelBuilding;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using File = Infrastructure.Persistence.Entities.File;
namespace Infrastructure.Persistence.Contexts;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccidentAreaCategorization> AccidentAreaCategorizations { get; set; }

    public virtual DbSet<AccidentDamageSizeDim> AccidentDamageSizeDims { get; set; }

    public virtual DbSet<AccidentLocationDescriptionDim> AccidentLocationDescriptionDims { get; set; }

    public virtual DbSet<AccidentTypeDim> AccidentTypeDims { get; set; }

    public virtual DbSet<AcessTypeDim> AcessTypeDims { get; set; }

    //public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<ActionTakenDim> ActionTakenDims { get; set; }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<ActivityAgencyContainerGuidView> ActivityAgencyContainerGuidViews { get; set; }

    public virtual DbSet<ActivityAgencyGuidView> ActivityAgencyGuidViews { get; set; }

    public virtual DbSet<ActivityAgencyView> ActivityAgencyViews { get; set; }

    public virtual DbSet<ActivityAircraftContainerGuidView> ActivityAircraftContainerGuidViews { get; set; }

    public virtual DbSet<ActivityAircraftGuidView> ActivityAircraftGuidViews { get; set; }

    public virtual DbSet<ActivityAircraftView> ActivityAircraftViews { get; set; }

    public virtual DbSet<ActivityArea> ActivityAreas { get; set; }

    public virtual DbSet<ActivityAreaContainerGuidView> ActivityAreaContainerGuidViews { get; set; }

    public virtual DbSet<ActivityAreaContainerView> ActivityAreaContainerViews { get; set; }

    public virtual DbSet<ActivityAreaGroup> ActivityAreaGroups { get; set; }

    public virtual DbSet<ActivityAreaGuidView> ActivityAreaGuidViews { get; set; }

    public virtual DbSet<ActivityAreaView> ActivityAreaViews { get; set; }

    public virtual DbSet<ActivityArticleContainerGuidView> ActivityArticleContainerGuidViews { get; set; }

    public virtual DbSet<ActivityArticleGuidView> ActivityArticleGuidViews { get; set; }

    public virtual DbSet<ActivityArticleView> ActivityArticleViews { get; set; }

    public virtual DbSet<ActivityAssociation> ActivityAssociations { get; set; }

    public virtual DbSet<ActivityAssociationGuidView> ActivityAssociationGuidViews { get; set; }

    public virtual DbSet<ActivityAssociationView> ActivityAssociationViews { get; set; }

    public virtual DbSet<ActivityAutoDispatch> ActivityAutoDispatches { get; set; }

    public virtual DbSet<ActivityCategoryDim> ActivityCategoryDims { get; set; }

    public virtual DbSet<ActivityCategoryDimcodeView> ActivityCategoryDimcodeViews { get; set; }

    public virtual DbSet<ActivityComment> ActivityComments { get; set; }

    public virtual DbSet<ActivityCommentContainerGuidView> ActivityCommentContainerGuidViews { get; set; }

    public virtual DbSet<ActivityCommentContainerView> ActivityCommentContainerViews { get; set; }

    public virtual DbSet<ActivityCommentGuidView> ActivityCommentGuidViews { get; set; }

    public virtual DbSet<ActivityCommentView> ActivityCommentViews { get; set; }

    public virtual DbSet<ActivityContact> ActivityContacts { get; set; }

    public virtual DbSet<ActivityContactContainerGuidView> ActivityContactContainerGuidViews { get; set; }

    public virtual DbSet<ActivityContactContainerView> ActivityContactContainerViews { get; set; }

    public virtual DbSet<ActivityContactGuidView> ActivityContactGuidViews { get; set; }

    public virtual DbSet<ActivityContactView> ActivityContactViews { get; set; }

    public virtual DbSet<ActivityConvertToStation> ActivityConvertToStations { get; set; }

    public virtual DbSet<ActivityConvertToStationArc> ActivityConvertToStationArcs { get; set; }

    public virtual DbSet<ActivityCourtContainerGuidView> ActivityCourtContainerGuidViews { get; set; }

    public virtual DbSet<ActivityCourtGuidView> ActivityCourtGuidViews { get; set; }

    public virtual DbSet<ActivityCourtView> ActivityCourtViews { get; set; }

    public virtual DbSet<ActivityDocument> ActivityDocuments { get; set; }

    public virtual DbSet<ActivityDocumentContainerGuidView> ActivityDocumentContainerGuidViews { get; set; }

    public virtual DbSet<ActivityDocumentContainerView> ActivityDocumentContainerViews { get; set; }

    public virtual DbSet<ActivityDocumentGuidView> ActivityDocumentGuidViews { get; set; }

    public virtual DbSet<ActivityDocumentView> ActivityDocumentViews { get; set; }

    public virtual DbSet<ActivityDrugContainerGuidView> ActivityDrugContainerGuidViews { get; set; }

    public virtual DbSet<ActivityDrugGuidView> ActivityDrugGuidViews { get; set; }

    public virtual DbSet<ActivityDrugView> ActivityDrugViews { get; set; }

    public virtual DbSet<ActivityEnforcementOfficialContainerGuidView> ActivityEnforcementOfficialContainerGuidViews { get; set; }

    public virtual DbSet<ActivityEnforcementOfficialGuidView> ActivityEnforcementOfficialGuidViews { get; set; }

    public virtual DbSet<ActivityEnforcementOfficialView> ActivityEnforcementOfficialViews { get; set; }

    public virtual DbSet<ActivityEvidenceContainerGuidView> ActivityEvidenceContainerGuidViews { get; set; }

    public virtual DbSet<ActivityEvidenceGuidView> ActivityEvidenceGuidViews { get; set; }

    public virtual DbSet<ActivityEvidenceView> ActivityEvidenceViews { get; set; }

    public virtual DbSet<ActivityFacilityContainerGuidView> ActivityFacilityContainerGuidViews { get; set; }

    public virtual DbSet<ActivityFacilityGuidView> ActivityFacilityGuidViews { get; set; }

    public virtual DbSet<ActivityFacilityView> ActivityFacilityViews { get; set; }

    public virtual DbSet<ActivityFirearmContainerGuidView> ActivityFirearmContainerGuidViews { get; set; }

    public virtual DbSet<ActivityFirearmGuidView> ActivityFirearmGuidViews { get; set; }

    public virtual DbSet<ActivityFirearmView> ActivityFirearmViews { get; set; }

    public virtual DbSet<ActivityImage> ActivityImages { get; set; }

    public virtual DbSet<ActivityImageContainerGuidView> ActivityImageContainerGuidViews { get; set; }

    public virtual DbSet<ActivityImageContainerView> ActivityImageContainerViews { get; set; }

    public virtual DbSet<ActivityImageGuidView> ActivityImageGuidViews { get; set; }

    public virtual DbSet<ActivityImageView> ActivityImageViews { get; set; }

    public virtual DbSet<ActivityInstanceEventsTable> ActivityInstanceEventsTables { get; set; }

    public virtual DbSet<ActivityItem> ActivityItems { get; set; }

    public virtual DbSet<ActivityItemContainerGuidView> ActivityItemContainerGuidViews { get; set; }

    public virtual DbSet<ActivityItemContainerView> ActivityItemContainerViews { get; set; }

    public virtual DbSet<ActivityItemGuidView> ActivityItemGuidViews { get; set; }

    public virtual DbSet<ActivityItemStatusDim> ActivityItemStatusDims { get; set; }

    public virtual DbSet<ActivityItemStatusLocation> ActivityItemStatusLocations { get; set; }

    public virtual DbSet<ActivityItemView> ActivityItemViews { get; set; }

    public virtual DbSet<ActivityJewelryContainerGuidView> ActivityJewelryContainerGuidViews { get; set; }

    public virtual DbSet<ActivityJewelryGuidView> ActivityJewelryGuidViews { get; set; }

    public virtual DbSet<ActivityJewelryView> ActivityJewelryViews { get; set; }

    public virtual DbSet<ActivityJudicialOfficialContainerGuidView> ActivityJudicialOfficialContainerGuidViews { get; set; }

    public virtual DbSet<ActivityJudicialOfficialGuidView> ActivityJudicialOfficialGuidViews { get; set; }

    public virtual DbSet<ActivityJudicialOfficialView> ActivityJudicialOfficialViews { get; set; }

    public virtual DbSet<ActivityJurorContainerGuidView> ActivityJurorContainerGuidViews { get; set; }

    public virtual DbSet<ActivityJurorGuidView> ActivityJurorGuidViews { get; set; }

    public virtual DbSet<ActivityJurorView> ActivityJurorViews { get; set; }

    public virtual DbSet<ActivityLicensePlateContainerGuidView> ActivityLicensePlateContainerGuidViews { get; set; }

    public virtual DbSet<ActivityLicensePlateGuidView> ActivityLicensePlateGuidViews { get; set; }

    public virtual DbSet<ActivityLicensePlateView> ActivityLicensePlateViews { get; set; }

    public virtual DbSet<ActivityLocation> ActivityLocations { get; set; }

    public virtual DbSet<ActivityLocationContainerGuidView> ActivityLocationContainerGuidViews { get; set; }

    public virtual DbSet<ActivityLocationContainerView> ActivityLocationContainerViews { get; set; }

    public virtual DbSet<ActivityLog> ActivityLogs { get; set; }

    public virtual DbSet<ActivityMissingPersonContainerGuidView> ActivityMissingPersonContainerGuidViews { get; set; }

    public virtual DbSet<ActivityMissingPersonGuidView> ActivityMissingPersonGuidViews { get; set; }

    public virtual DbSet<ActivityMissingPersonView> ActivityMissingPersonViews { get; set; }

    public virtual DbSet<ActivityOrganization> ActivityOrganizations { get; set; }

    public virtual DbSet<ActivityOrganizationContainerGuidView> ActivityOrganizationContainerGuidViews { get; set; }

    public virtual DbSet<ActivityOrganizationContainerView> ActivityOrganizationContainerViews { get; set; }

    public virtual DbSet<ActivityOrganizationGuidView> ActivityOrganizationGuidViews { get; set; }

    public virtual DbSet<ActivityOrganizationView> ActivityOrganizationViews { get; set; }

    public virtual DbSet<ActivityPerson> ActivityPeople { get; set; }

    public virtual DbSet<ActivityPersonContainerGuidView> ActivityPersonContainerGuidViews { get; set; }

    public virtual DbSet<ActivityPersonContainerView> ActivityPersonContainerViews { get; set; }

    public virtual DbSet<ActivityPersonGuidView> ActivityPersonGuidViews { get; set; }

    public virtual DbSet<ActivityPersonView> ActivityPersonViews { get; set; }

    public virtual DbSet<ActivityProviderContainerGuidView> ActivityProviderContainerGuidViews { get; set; }

    public virtual DbSet<ActivityProviderGuidView> ActivityProviderGuidViews { get; set; }

    public virtual DbSet<ActivityProviderView> ActivityProviderViews { get; set; }

    public virtual DbSet<ActivityQuestionnaireContainerGuidView> ActivityQuestionnaireContainerGuidViews { get; set; }

    public virtual DbSet<ActivityQuestionnaireGuidView> ActivityQuestionnaireGuidViews { get; set; }

    public virtual DbSet<ActivityQuestionnaireView> ActivityQuestionnaireViews { get; set; }

    public virtual DbSet<ActivityRealestateContainerGuidView> ActivityRealestateContainerGuidViews { get; set; }

    public virtual DbSet<ActivityRealestateGuidView> ActivityRealestateGuidViews { get; set; }

    public virtual DbSet<ActivityRealestateView> ActivityRealestateViews { get; set; }

    public virtual DbSet<ActivityReasonDim> ActivityReasonDims { get; set; }

    public virtual DbSet<ActivityReasonDimcodeView> ActivityReasonDimcodeViews { get; set; }

    public virtual DbSet<ActivityRelationshipCategoryDim> ActivityRelationshipCategoryDims { get; set; }

    public virtual DbSet<ActivityRelationshipCategoryDimcodeView> ActivityRelationshipCategoryDimcodeViews { get; set; }

    public virtual DbSet<ActivityRelationshipTypeDim> ActivityRelationshipTypeDims { get; set; }

    public virtual DbSet<ActivityRelationshipTypeDimcodeView> ActivityRelationshipTypeDimcodeViews { get; set; }

    public virtual DbSet<ActivityReport> ActivityReports { get; set; }

    public virtual DbSet<ActivitySocialMediaContainerGuidView> ActivitySocialMediaContainerGuidViews { get; set; }

    public virtual DbSet<ActivitySocialMediaContainerView> ActivitySocialMediaContainerViews { get; set; }

    public virtual DbSet<ActivitySocialMediaGuidView> ActivitySocialMediaGuidViews { get; set; }

    public virtual DbSet<ActivitySocialMediaView> ActivitySocialMediaViews { get; set; }

    public virtual DbSet<ActivitySocialMedium> ActivitySocialMedia { get; set; }

    public virtual DbSet<ActivitySubjectContainerGuidView> ActivitySubjectContainerGuidViews { get; set; }

    public virtual DbSet<ActivitySubjectGuidView> ActivitySubjectGuidViews { get; set; }

    public virtual DbSet<ActivitySubjectOrganizationContainerGuidView> ActivitySubjectOrganizationContainerGuidViews { get; set; }

    public virtual DbSet<ActivitySubjectOrganizationGuidView> ActivitySubjectOrganizationGuidViews { get; set; }

    public virtual DbSet<ActivitySubjectOrganizationView> ActivitySubjectOrganizationViews { get; set; }

    public virtual DbSet<ActivitySubjectView> ActivitySubjectViews { get; set; }

    public virtual DbSet<ActivitySubscription> ActivitySubscriptions { get; set; }

    public virtual DbSet<ActivitySubscriptionContainerGuidView> ActivitySubscriptionContainerGuidViews { get; set; }

    public virtual DbSet<ActivitySubscriptionContainerView> ActivitySubscriptionContainerViews { get; set; }

    public virtual DbSet<ActivitySubscriptionGuidView> ActivitySubscriptionGuidViews { get; set; }

    public virtual DbSet<ActivitySubscriptionView> ActivitySubscriptionViews { get; set; }

    public virtual DbSet<ActivityTask> ActivityTasks { get; set; }

    public virtual DbSet<ActivityTransaction> ActivityTransactions { get; set; }

    public virtual DbSet<ActivityUserContainerGuidView> ActivityUserContainerGuidViews { get; set; }

    public virtual DbSet<ActivityUserGuidView> ActivityUserGuidViews { get; set; }

    public virtual DbSet<ActivityUserView> ActivityUserViews { get; set; }

    public virtual DbSet<ActivityVehicleContainerGuidView> ActivityVehicleContainerGuidViews { get; set; }

    public virtual DbSet<ActivityVehicleDatum> ActivityVehicleData { get; set; }

    public virtual DbSet<ActivityVehicleGuidView> ActivityVehicleGuidViews { get; set; }

    public virtual DbSet<ActivityVehicleView> ActivityVehicleViews { get; set; }

    public virtual DbSet<ActivityVesselContainerGuidView> ActivityVesselContainerGuidViews { get; set; }

    public virtual DbSet<ActivityVesselGuidView> ActivityVesselGuidViews { get; set; }

    public virtual DbSet<ActivityVesselView> ActivityVesselViews { get; set; }

    public virtual DbSet<ActivityVictimContainerGuidView> ActivityVictimContainerGuidViews { get; set; }

    public virtual DbSet<ActivityVictimGuidView> ActivityVictimGuidViews { get; set; }

    public virtual DbSet<ActivityVictimView> ActivityVictimViews { get; set; }

    public virtual DbSet<AdpemirateResponseRate> AdpemirateResponseRates { get; set; }

    public virtual DbSet<AdpemirateResponseRateMonthly> AdpemirateResponseRateMonthlies { get; set; }

    public virtual DbSet<AdpresponseCalculationRequest> AdpresponseCalculationRequests { get; set; }

    public virtual DbSet<AdpresponseCalculationRequestsMonthly> AdpresponseCalculationRequestsMonthlies { get; set; }

    public virtual DbSet<AffectedLaneDim> AffectedLaneDims { get; set; }

    public virtual DbSet<Agency> Agencies { get; set; }

    public virtual DbSet<AgencyCategoryDim> AgencyCategoryDims { get; set; }

    public virtual DbSet<AgencyCategoryDimcodeView> AgencyCategoryDimcodeViews { get; set; }

    public virtual DbSet<AgencyGuidView> AgencyGuidViews { get; set; }

    public virtual DbSet<AgencyView> AgencyViews { get; set; }

    public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }

    public virtual DbSet<Aircraft> Aircraft { get; set; }

    public virtual DbSet<AircraftCategoryDim> AircraftCategoryDims { get; set; }

    public virtual DbSet<AircraftCategoryDimcodeView> AircraftCategoryDimcodeViews { get; set; }

    public virtual DbSet<AircraftGuidView> AircraftGuidViews { get; set; }

    public virtual DbSet<AircraftUsageDim> AircraftUsageDims { get; set; }

    public virtual DbSet<AircraftUsageDimcodeView> AircraftUsageDimcodeViews { get; set; }

    public virtual DbSet<AircraftView> AircraftViews { get; set; }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<AlertAudienceDim> AlertAudienceDims { get; set; }

    public virtual DbSet<AlertAudienceDimcodeView> AlertAudienceDimcodeViews { get; set; }

    public virtual DbSet<AlertCategoryDim> AlertCategoryDims { get; set; }

    public virtual DbSet<AlertCategoryDimcodeView> AlertCategoryDimcodeViews { get; set; }

    public virtual DbSet<AlertCertaintyDim> AlertCertaintyDims { get; set; }

    public virtual DbSet<AlertCertaintyDimcodeView> AlertCertaintyDimcodeViews { get; set; }

    public virtual DbSet<AlertEventDim> AlertEventDims { get; set; }

    public virtual DbSet<AlertEventDimcodeView> AlertEventDimcodeViews { get; set; }

    public virtual DbSet<AlertHandlingDim> AlertHandlingDims { get; set; }

    public virtual DbSet<AlertHandlingDimcodeView> AlertHandlingDimcodeViews { get; set; }

    public virtual DbSet<AlertInstructionDim> AlertInstructionDims { get; set; }

    public virtual DbSet<AlertInstructionDimcodeView> AlertInstructionDimcodeViews { get; set; }

    public virtual DbSet<AlertReasonDim> AlertReasonDims { get; set; }

    public virtual DbSet<AlertReasonDimcodeView> AlertReasonDimcodeViews { get; set; }

    public virtual DbSet<AlertSenderDim> AlertSenderDims { get; set; }

    public virtual DbSet<AlertSenderDimcodeView> AlertSenderDimcodeViews { get; set; }

    public virtual DbSet<AlertSeverityDim> AlertSeverityDims { get; set; }

    public virtual DbSet<AlertSeverityDimcodeView> AlertSeverityDimcodeViews { get; set; }

    public virtual DbSet<AlertTargetDim> AlertTargetDims { get; set; }

    public virtual DbSet<AlertTargetDimcodeView> AlertTargetDimcodeViews { get; set; }

    public virtual DbSet<AlertUrgencyDim> AlertUrgencyDims { get; set; }

    public virtual DbSet<AlertUrgencyDimcodeView> AlertUrgencyDimcodeViews { get; set; }

    public virtual DbSet<AndroidException> AndroidExceptions { get; set; }



    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<ApplicationPage> ApplicationPages { get; set; }

    public virtual DbSet<ApplicationPagesCategoryDim> ApplicationPagesCategoryDims { get; set; }

    public virtual DbSet<ApprovalCycle> ApprovalCycles { get; set; }

    public virtual DbSet<ArcaverageTime> ArcaverageTimes { get; set; }

    public virtual DbSet<ArcaverageTime15> ArcaverageTime15s { get; set; }

    public virtual DbSet<ArcaverageTimeOld> ArcaverageTimeOlds { get; set; }

    public virtual DbSet<ArcproActionLog> ArcproActionLogs { get; set; }

    public virtual DbSet<ArcproActionLogTypeDim> ArcproActionLogTypeDims { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AreaAllowedMobileNumber> AreaAllowedMobileNumbers { get; set; }

    public virtual DbSet<AreaAssociation> AreaAssociations { get; set; }

    public virtual DbSet<AreaCategoryDim> AreaCategoryDims { get; set; }

    public virtual DbSet<AreaCategoryDimcodeView> AreaCategoryDimcodeViews { get; set; }

    public virtual DbSet<AreaGroupDim> AreaGroupDims { get; set; }

    public virtual DbSet<AreaGuidView> AreaGuidViews { get; set; }

    public virtual DbSet<AreaInvolvementDim> AreaInvolvementDims { get; set; }

    public virtual DbSet<AreaInvolvementDimcodeView> AreaInvolvementDimcodeViews { get; set; }

    public virtual DbSet<AreaItem> AreaItems { get; set; }


    public virtual DbSet<AreaRelationshipCategoryDim> AreaRelationshipCategoryDims { get; set; }

    public virtual DbSet<AreaRelationshipTypeDim> AreaRelationshipTypeDims { get; set; }

    public virtual DbSet<AreaSupportNumber> AreaSupportNumbers { get; set; }

    public virtual DbSet<AreaView> AreaViews { get; set; }

    public virtual DbSet<ArmyNotificationLog> ArmyNotificationLogs { get; set; }

    public virtual DbSet<Arrest> Arrests { get; set; }

    public virtual DbSet<ArrestCategoryDim> ArrestCategoryDims { get; set; }

    public virtual DbSet<ArrestCategoryDimcodeView> ArrestCategoryDimcodeViews { get; set; }

    public virtual DbSet<ArrestCharge> ArrestCharges { get; set; }

    public virtual DbSet<ArrestChargeContainerGuidView> ArrestChargeContainerGuidViews { get; set; }

    public virtual DbSet<ArrestChargeContainerView> ArrestChargeContainerViews { get; set; }

    public virtual DbSet<ArrestChargeGuidView> ArrestChargeGuidViews { get; set; }

    public virtual DbSet<ArrestChargeView> ArrestChargeViews { get; set; }

    public virtual DbSet<ArrestProbableCauseDim> ArrestProbableCauseDims { get; set; }

    public virtual DbSet<ArrestProbableCauseDimcodeView> ArrestProbableCauseDimcodeViews { get; set; }

    public virtual DbSet<ArrestRightsReadResponseDim> ArrestRightsReadResponseDims { get; set; }

    public virtual DbSet<ArrestRightsReadResponseDimcodeView> ArrestRightsReadResponseDimcodeViews { get; set; }

    public virtual DbSet<ArrestWarrant> ArrestWarrants { get; set; }

    public virtual DbSet<ArrestWarrantContainerGuidView> ArrestWarrantContainerGuidViews { get; set; }

    public virtual DbSet<ArrestWarrantContainerView> ArrestWarrantContainerViews { get; set; }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<ArticleCategoryDim> ArticleCategoryDims { get; set; }

    public virtual DbSet<ArticleCategoryDimcodeView> ArticleCategoryDimcodeViews { get; set; }

    public virtual DbSet<ArticleGuidView> ArticleGuidViews { get; set; }

    public virtual DbSet<ArticleTypeDim> ArticleTypeDims { get; set; }

    public virtual DbSet<ArticleTypeDimcodeView> ArticleTypeDimcodeViews { get; set; }

    public virtual DbSet<ArticleView> ArticleViews { get; set; }

    public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }

    public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; }

    public virtual DbSet<AspnetPath> AspnetPaths { get; set; }

    public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; }

    public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }

    public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; }

    public virtual DbSet<AspnetRole> AspnetRoles { get; set; }

    public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }

    public virtual DbSet<AspnetUser> AspnetUsers { get; set; }

    public virtual DbSet<AspnetUsersInRole> AspnetUsersInRoles { get; set; }

    public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; }

    public virtual DbSet<Assessment> Assessments { get; set; }

    public virtual DbSet<AssessmentResponse> AssessmentResponses { get; set; }

    public virtual DbSet<AssessmentResponseGuidView> AssessmentResponseGuidViews { get; set; }

    public virtual DbSet<AssessmentResponseView> AssessmentResponseViews { get; set; }

    public virtual DbSet<AssignmentPushRetry> AssignmentPushRetries { get; set; }

    public virtual DbSet<Audit> Audits { get; set; }

    public virtual DbSet<AuditCategoryDim> AuditCategoryDims { get; set; }

    public virtual DbSet<AuditCategoryDimcodeView> AuditCategoryDimcodeViews { get; set; }

    public virtual DbSet<AuditDetail> AuditDetails { get; set; }

    public virtual DbSet<AuditDetailGuidView> AuditDetailGuidViews { get; set; }

    public virtual DbSet<AuditDetailView> AuditDetailViews { get; set; }

    public virtual DbSet<AuditTrailTable> AuditTrailTables { get; set; }

    public virtual DbSet<AuthorizationTypeDim> AuthorizationTypeDims { get; set; }

    public virtual DbSet<AuthorizationTypeDimcodeView> AuthorizationTypeDimcodeViews { get; set; }

    public virtual DbSet<AutoDispatchConfiguration> AutoDispatchConfigurations { get; set; }

    public virtual DbSet<AutoDispatchLog> AutoDispatchLogs { get; set; }

    public virtual DbSet<AutomationReportsTable> AutomationReportsTables { get; set; }

    public virtual DbSet<AutomationReportsType> AutomationReportsTypes { get; set; }

    public virtual DbSet<AverageReconstructionTimePerMonth> AverageReconstructionTimePerMonths { get; set; }

    public virtual DbSet<AverageResponseTimeByMonth> AverageResponseTimeByMonths { get; set; }

    public virtual DbSet<Bail> Bails { get; set; }

    public virtual DbSet<BailConditionDim> BailConditionDims { get; set; }

    public virtual DbSet<BailConditionDimcodeView> BailConditionDimcodeViews { get; set; }

    public virtual DbSet<BailRequirementDim> BailRequirementDims { get; set; }

    public virtual DbSet<BailRequirementDimcodeView> BailRequirementDimcodeViews { get; set; }



    public virtual DbSet<Bolo> Bolos { get; set; }

    public virtual DbSet<BoloCategoryDim> BoloCategoryDims { get; set; }

    public virtual DbSet<BoloCategoryDimcodeView> BoloCategoryDimcodeViews { get; set; }

    public virtual DbSet<Bond> Bonds { get; set; }

    public virtual DbSet<BondConditionDim> BondConditionDims { get; set; }

    public virtual DbSet<BondConditionDimcodeView> BondConditionDimcodeViews { get; set; }

    public virtual DbSet<BondPaymentDim> BondPaymentDims { get; set; }

    public virtual DbSet<BondPaymentDimcodeView> BondPaymentDimcodeViews { get; set; }

    public virtual DbSet<BondTerminationCategoryDim> BondTerminationCategoryDims { get; set; }

    public virtual DbSet<BondTerminationCategoryDimcodeView> BondTerminationCategoryDimcodeViews { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<BookmarkResumptionEventsTable> BookmarkResumptionEventsTables { get; set; }

    public virtual DbSet<CancelDispatchDeatilsView> CancelDispatchDeatilsViews { get; set; }

    public virtual DbSet<CancelReasonDim> CancelReasonDims { get; set; }

    public virtual DbSet<CancelledIncidentView> CancelledIncidentViews { get; set; }


    public virtual DbSet<Case> Cases { get; set; }

    public virtual DbSet<CaseCategoryDim> CaseCategoryDims { get; set; }

    public virtual DbSet<CaseCategoryDimcodeView> CaseCategoryDimcodeViews { get; set; }

    public virtual DbSet<CaseCharge> CaseCharges { get; set; }

    public virtual DbSet<CaseChargeContainerGuidView> CaseChargeContainerGuidViews { get; set; }

    public virtual DbSet<CaseChargeContainerView> CaseChargeContainerViews { get; set; }

    public virtual DbSet<CaseChargeGuidView> CaseChargeGuidViews { get; set; }

    public virtual DbSet<CaseChargeView> CaseChargeViews { get; set; }

    public virtual DbSet<CaseExhibit> CaseExhibits { get; set; }

    public virtual DbSet<CaseExhibitEvidence> CaseExhibitEvidences { get; set; }

    public virtual DbSet<CaseExhibitEvidenceContainerGuidView> CaseExhibitEvidenceContainerGuidViews { get; set; }

    public virtual DbSet<CaseExhibitEvidenceContainerView> CaseExhibitEvidenceContainerViews { get; set; }

    public virtual DbSet<CaseExhibitStatusDim> CaseExhibitStatusDims { get; set; }

    public virtual DbSet<CaseExhibitStatusDimcodeView> CaseExhibitStatusDimcodeViews { get; set; }

    public virtual DbSet<CaseRestrictionDim> CaseRestrictionDims { get; set; }

    public virtual DbSet<CaseRestrictionDimcodeView> CaseRestrictionDimcodeViews { get; set; }

    public virtual DbSet<CaseSecurityDim> CaseSecurityDims { get; set; }

    public virtual DbSet<CaseSecurityDimcodeView> CaseSecurityDimcodeViews { get; set; }

    public virtual DbSet<CaseSeverityDim> CaseSeverityDims { get; set; }

    public virtual DbSet<CaseSeverityDimcodeView> CaseSeverityDimcodeViews { get; set; }

    public virtual DbSet<CaseSolvabilityDim> CaseSolvabilityDims { get; set; }

    public virtual DbSet<CaseSolvabilityDimcodeView> CaseSolvabilityDimcodeViews { get; set; }

    public virtual DbSet<CaseStatusDim> CaseStatusDims { get; set; }

    public virtual DbSet<CaseStatusDimcodeView> CaseStatusDimcodeViews { get; set; }

    public virtual DbSet<CaseTerminationCategoryDim> CaseTerminationCategoryDims { get; set; }

    public virtual DbSet<CaseTerminationCategoryDimcodeView> CaseTerminationCategoryDimcodeViews { get; set; }

    public virtual DbSet<CaseTerminationStageDim> CaseTerminationStageDims { get; set; }

    public virtual DbSet<CaseTerminationStageDimcodeView> CaseTerminationStageDimcodeViews { get; set; }

    public virtual DbSet<CautionInformationDim> CautionInformationDims { get; set; }

    public virtual DbSet<CautionInformationDimcodeView> CautionInformationDimcodeViews { get; set; }

    public virtual DbSet<ChangePasswordSession> ChangePasswordSessions { get; set; }


    public virtual DbSet<ChemicalDim> ChemicalDims { get; set; }

    public virtual DbSet<Citation> Citations { get; set; }

    public virtual DbSet<CitationDismissalConditionDim> CitationDismissalConditionDims { get; set; }

    public virtual DbSet<CitationDismissalConditionDimcodeView> CitationDismissalConditionDimcodeViews { get; set; }

    public virtual DbSet<CitationStatusDim> CitationStatusDims { get; set; }

    public virtual DbSet<CitationStatusDimcodeView> CitationStatusDimcodeViews { get; set; }

    public virtual DbSet<CitationViolation> CitationViolations { get; set; }

    public virtual DbSet<CitationViolationGuidView> CitationViolationGuidViews { get; set; }

    public virtual DbSet<CitationViolationView> CitationViolationViews { get; set; }

    public virtual DbSet<CityDim> CityDims { get; set; }

    public virtual DbSet<ClassificationDim> ClassificationDims { get; set; }

    public virtual DbSet<ClassificationDimcodeView> ClassificationDimcodeViews { get; set; }

    public virtual DbSet<ClientApplication> ClientApplications { get; set; }

    public virtual DbSet<CloseIncReasaon> CloseIncReasaons { get; set; }

    public virtual DbSet<CollisionDim> CollisionDims { get; set; }

    public virtual DbSet<CollisionTypeDim> CollisionTypeDims { get; set; }

    public virtual DbSet<ColorDim> ColorDims { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<CommentCategoryDim> CommentCategoryDims { get; set; }

    public virtual DbSet<CommentCategoryDimcodeView> CommentCategoryDimcodeViews { get; set; }

    public virtual DbSet<CommentGuidView> CommentGuidViews { get; set; }

    public virtual DbSet<CommentInvolvementDim> CommentInvolvementDims { get; set; }

    public virtual DbSet<CommentInvolvementDimcodeView> CommentInvolvementDimcodeViews { get; set; }

    public virtual DbSet<CommentView> CommentViews { get; set; }

    public virtual DbSet<CommissionArea> CommissionAreas { get; set; }

    public virtual DbSet<CommissionReportFact> CommissionReportFacts { get; set; }

    public virtual DbSet<CommissionThresholdDim> CommissionThresholdDims { get; set; }

    public virtual DbSet<CommissionTypeDim> CommissionTypeDims { get; set; }

    public virtual DbSet<CommonErrorMessage> CommonErrorMessages { get; set; }

    public virtual DbSet<CommunicationMethodsDim> CommunicationMethodsDims { get; set; }

    public virtual DbSet<CommunityService> CommunityServices { get; set; }

    public virtual DbSet<CommunityServiceCategoryDim> CommunityServiceCategoryDims { get; set; }

    public virtual DbSet<CommunityServiceCategoryDimcodeView> CommunityServiceCategoryDimcodeViews { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyAttachment> CompanyAttachments { get; set; }

    public virtual DbSet<CompanyPatrolsBalance> CompanyPatrolsBalances { get; set; }

    public virtual DbSet<CompanyPatrolsBalanceLog> CompanyPatrolsBalanceLogs { get; set; }

    public virtual DbSet<CompanyUser> CompanyUsers { get; set; }

    public virtual DbSet<CompanyVehicle> CompanyVehicles { get; set; }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<ConditionGroupDim> ConditionGroupDims { get; set; }

    public virtual DbSet<ConditionGroupDimcodeView> ConditionGroupDimcodeViews { get; set; }

    public virtual DbSet<ConditionViolationDim> ConditionViolationDims { get; set; }

    public virtual DbSet<ConditionViolationDimcodeView> ConditionViolationDimcodeViews { get; set; }

    public virtual DbSet<ConfWfAction> ConfWfActions { get; set; }

    public virtual DbSet<ConfWfLevel> ConfWfLevels { get; set; }

    public virtual DbSet<ConfWfTransaction> ConfWfTransactions { get; set; }

    public virtual DbSet<ConfWfWorkFlow> ConfWfWorkFlows { get; set; }

    public virtual DbSet<ConfiscationDocumentTypeDim> ConfiscationDocumentTypeDims { get; set; }

    public virtual DbSet<ConfiscationLocationDim> ConfiscationLocationDims { get; set; }

    public virtual DbSet<ConfiscationStatusDim> ConfiscationStatusDims { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactCategoryDim> ContactCategoryDims { get; set; }

    public virtual DbSet<ContactCategoryDimcodeView> ContactCategoryDimcodeViews { get; set; }

    public virtual DbSet<ContactComment> ContactComments { get; set; }

    public virtual DbSet<ContactCommentContainerGuidView> ContactCommentContainerGuidViews { get; set; }

    public virtual DbSet<ContactCommentContainerView> ContactCommentContainerViews { get; set; }

    public virtual DbSet<ContactCommentGuidView> ContactCommentGuidViews { get; set; }

    public virtual DbSet<ContactCommentView> ContactCommentViews { get; set; }

    public virtual DbSet<ContactGuidView> ContactGuidViews { get; set; }

    public virtual DbSet<ContactInvolvementDim> ContactInvolvementDims { get; set; }

    public virtual DbSet<ContactInvolvementDimcodeView> ContactInvolvementDimcodeViews { get; set; }

    public virtual DbSet<ContactView> ContactViews { get; set; }

    public virtual DbSet<CopartSmslog> CopartSmslogs { get; set; }

    public virtual DbSet<Correction> Corrections { get; set; }

    public virtual DbSet<Counseling> Counselings { get; set; }

    public virtual DbSet<CounselingCategoryDim> CounselingCategoryDims { get; set; }

    public virtual DbSet<CounselingCategoryDimcodeView> CounselingCategoryDimcodeViews { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<Court> Courts { get; set; }

    public virtual DbSet<CourtAction> CourtActions { get; set; }

    public virtual DbSet<CourtActionCategoryDim> CourtActionCategoryDims { get; set; }

    public virtual DbSet<CourtActionCategoryDimcodeView> CourtActionCategoryDimcodeViews { get; set; }

    public virtual DbSet<CourtCategoryDim> CourtCategoryDims { get; set; }

    public virtual DbSet<CourtCategoryDimcodeView> CourtCategoryDimcodeViews { get; set; }

    public virtual DbSet<CourtEvent> CourtEvents { get; set; }

    public virtual DbSet<CourtEventCategoryDim> CourtEventCategoryDims { get; set; }

    public virtual DbSet<CourtEventCategoryDimcodeView> CourtEventCategoryDimcodeViews { get; set; }

    public virtual DbSet<CourtGuidView> CourtGuidViews { get; set; }

    public virtual DbSet<CourtOrder> CourtOrders { get; set; }

    public virtual DbSet<CourtOrderCategoryDim> CourtOrderCategoryDims { get; set; }

    public virtual DbSet<CourtOrderCategoryDimcodeView> CourtOrderCategoryDimcodeViews { get; set; }

    public virtual DbSet<CourtOrderProtectionConditionDim> CourtOrderProtectionConditionDims { get; set; }

    public virtual DbSet<CourtOrderProtectionConditionDimcodeView> CourtOrderProtectionConditionDimcodeViews { get; set; }

    public virtual DbSet<CourtOrderRecallReasonDim> CourtOrderRecallReasonDims { get; set; }

    public virtual DbSet<CourtOrderRecallReasonDimcodeView> CourtOrderRecallReasonDimcodeViews { get; set; }

    public virtual DbSet<CourtOrderServiceCautionDim> CourtOrderServiceCautionDims { get; set; }

    public virtual DbSet<CourtOrderServiceCautionDimcodeView> CourtOrderServiceCautionDimcodeViews { get; set; }

    public virtual DbSet<CourtOrderSignatureMethodDim> CourtOrderSignatureMethodDims { get; set; }

    public virtual DbSet<CourtOrderSignatureMethodDimcodeView> CourtOrderSignatureMethodDimcodeViews { get; set; }

    public virtual DbSet<CourtOrderSpecialInstructionDim> CourtOrderSpecialInstructionDims { get; set; }

    public virtual DbSet<CourtOrderSpecialInstructionDimcodeView> CourtOrderSpecialInstructionDimcodeViews { get; set; }

    public virtual DbSet<CourtOrderStatusDim> CourtOrderStatusDims { get; set; }

    public virtual DbSet<CourtOrderStatusDimcodeView> CourtOrderStatusDimcodeViews { get; set; }

    public virtual DbSet<CourtOrderWarrant> CourtOrderWarrants { get; set; }

    public virtual DbSet<CourtOrderWarrantContainerGuidView> CourtOrderWarrantContainerGuidViews { get; set; }

    public virtual DbSet<CourtOrderWarrantContainerView> CourtOrderWarrantContainerViews { get; set; }

    public virtual DbSet<CourtView> CourtViews { get; set; }

    public virtual DbSet<CriminalInvolvementDim> CriminalInvolvementDims { get; set; }

    public virtual DbSet<CriminalInvolvementDimcodeView> CriminalInvolvementDimcodeViews { get; set; }

    public virtual DbSet<CriminalTraitActivityDim> CriminalTraitActivityDims { get; set; }

    public virtual DbSet<CriminalTraitActivityDimcodeView> CriminalTraitActivityDimcodeViews { get; set; }

    public virtual DbSet<CriminalTraitColorDim> CriminalTraitColorDims { get; set; }

    public virtual DbSet<CriminalTraitColorDimcodeView> CriminalTraitColorDimcodeViews { get; set; }

    public virtual DbSet<CriminalTraitCommunicationDim> CriminalTraitCommunicationDims { get; set; }

    public virtual DbSet<CriminalTraitCommunicationDimcodeView> CriminalTraitCommunicationDimcodeViews { get; set; }

    public virtual DbSet<CriminalTraitDim> CriminalTraitDims { get; set; }

    public virtual DbSet<CriminalTraitDimcodeView> CriminalTraitDimcodeViews { get; set; }

    public virtual DbSet<CriminalTraitDressDim> CriminalTraitDressDims { get; set; }

    public virtual DbSet<CriminalTraitDressDimcodeView> CriminalTraitDressDimcodeViews { get; set; }

    public virtual DbSet<CriminalTraitHandSignalDim> CriminalTraitHandSignalDims { get; set; }

    public virtual DbSet<CriminalTraitHandSignalDimcodeView> CriminalTraitHandSignalDimcodeViews { get; set; }

    public virtual DbSet<CriminalTraitModusOperandiDim> CriminalTraitModusOperandiDims { get; set; }

    public virtual DbSet<CriminalTraitModusOperandiDimcodeView> CriminalTraitModusOperandiDimcodeViews { get; set; }

    public virtual DbSet<CriminalTraitTargetDim> CriminalTraitTargetDims { get; set; }

    public virtual DbSet<CriminalTraitTargetDimcodeView> CriminalTraitTargetDimcodeViews { get; set; }

    public virtual DbSet<CrossStreetDim> CrossStreetDims { get; set; }

    public virtual DbSet<CustodyTransfer> CustodyTransfers { get; set; }

    public virtual DbSet<CustodyTransferActionDim> CustodyTransferActionDims { get; set; }

    public virtual DbSet<CustodyTransferActionDimcodeView> CustodyTransferActionDimcodeViews { get; set; }

    public virtual DbSet<CustomLookup> CustomLookups { get; set; }

    public virtual DbSet<CustomTrackingEventsTable> CustomTrackingEventsTables { get; set; }

    public virtual DbSet<CustomerNotAnswerReason> CustomerNotAnswerReasons { get; set; }

    public virtual DbSet<DailyTrafficStatisticsView> DailyTrafficStatisticsViews { get; set; }

    public virtual DbSet<DamagePartsDim> DamagePartsDims { get; set; }

    public virtual DbSet<DamagedPartSeverityDim> DamagedPartSeverityDims { get; set; }

    public virtual DbSet<DamagedProperty> DamagedProperties { get; set; }

    public virtual DbSet<DamagedVehiclePart> DamagedVehicleParts { get; set; }

    public virtual DbSet<DamagedVehiclePartsDim> DamagedVehiclePartsDims { get; set; }

    public virtual DbSet<DataInsightHubIntegrationTokenLog> DataInsightHubIntegrationTokenLogs { get; set; }

    public virtual DbSet<DataInsightHubReport> DataInsightHubReports { get; set; }

    public virtual DbSet<DataInsightHubReportCategory> DataInsightHubReportCategories { get; set; }

    public virtual DbSet<DataInsightHubReportDisplayColumn> DataInsightHubReportDisplayColumns { get; set; }

    public virtual DbSet<DataMaskingDemo> DataMaskingDemos { get; set; }

    public virtual DbSet<DateDim> DateDims { get; set; }

    public virtual DbSet<DateTimeDim> DateTimeDims { get; set; }

    public virtual DbSet<DelayedOpenedIncidentsByStatusView> DelayedOpenedIncidentsByStatusViews { get; set; }

    public virtual DbSet<DeliveryCompanyDim> DeliveryCompanyDims { get; set; }

    public virtual DbSet<DentalCharacteristicDim> DentalCharacteristicDims { get; set; }

    public virtual DbSet<DentalCharacteristicDimcodeView> DentalCharacteristicDimcodeViews { get; set; }

    public virtual DbSet<DentalCharacteristicRestorationDim> DentalCharacteristicRestorationDims { get; set; }

    public virtual DbSet<DentalCharacteristicRestorationDimcodeView> DentalCharacteristicRestorationDimcodeViews { get; set; }

    public virtual DbSet<DentalStatusDim> DentalStatusDims { get; set; }

    public virtual DbSet<DentalStatusDimcodeView> DentalStatusDimcodeViews { get; set; }

    public virtual DbSet<DentalToothPositionDim> DentalToothPositionDims { get; set; }

    public virtual DbSet<DentalToothPositionDimcodeView> DentalToothPositionDimcodeViews { get; set; }

    public virtual DbSet<DetectLocationConfiguration> DetectLocationConfigurations { get; set; }

    public virtual DbSet<DetectLocationLog> DetectLocationLogs { get; set; }

    public virtual DbSet<DeviceInformation> DeviceInformations { get; set; }

    public virtual DbSet<DeviceType> DeviceTypes { get; set; }

    public virtual DbSet<DimVehiclesModificationDate> DimVehiclesModificationDates { get; set; }

    public virtual DbSet<DirectPaymentReasonDim> DirectPaymentReasonDims { get; set; }

    public virtual DbSet<DirectPaymentSourceDim> DirectPaymentSourceDims { get; set; }

    public virtual DbSet<DirectPaymentStatusDim> DirectPaymentStatusDims { get; set; }

    public virtual DbSet<DirectPaymentTransaction> DirectPaymentTransactions { get; set; }

    public virtual DbSet<DirectPaymentTransactionLog> DirectPaymentTransactionLogs { get; set; }

    public virtual DbSet<DisciplinaryAction> DisciplinaryActions { get; set; }

    public virtual DbSet<Disposition> Dispositions { get; set; }

    public virtual DbSet<DispositionCategoryDim> DispositionCategoryDims { get; set; }

    public virtual DbSet<DispositionCategoryDimcodeView> DispositionCategoryDimcodeViews { get; set; }

    public virtual DbSet<DispositionReasonDim> DispositionReasonDims { get; set; }

    public virtual DbSet<DispositionReasonDimcodeView> DispositionReasonDimcodeViews { get; set; }

    public virtual DbSet<Dissemination> Disseminations { get; set; }

    public virtual DbSet<DisseminationMethodDim> DisseminationMethodDims { get; set; }

    public virtual DbSet<DisseminationMethodDimcodeView> DisseminationMethodDimcodeViews { get; set; }

    public virtual DbSet<DnacollectionStatusDim> DnacollectionStatusDims { get; set; }

    public virtual DbSet<DnacollectionStatusDimcodeView> DnacollectionStatusDimcodeViews { get; set; }

    public virtual DbSet<Docket> Dockets { get; set; }

    public virtual DbSet<DocketCategoryDim> DocketCategoryDims { get; set; }

    public virtual DbSet<DocketCategoryDimcodeView> DocketCategoryDimcodeViews { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentCategoryDim> DocumentCategoryDims { get; set; }

    public virtual DbSet<DocumentCategoryDimcodeView> DocumentCategoryDimcodeViews { get; set; }

    public virtual DbSet<DocumentFormatDim> DocumentFormatDims { get; set; }

    public virtual DbSet<DocumentFormatDimcodeView> DocumentFormatDimcodeViews { get; set; }

    public virtual DbSet<DocumentGuidView> DocumentGuidViews { get; set; }

    public virtual DbSet<DocumentInvolvementDim> DocumentInvolvementDims { get; set; }

    public virtual DbSet<DocumentInvolvementDimcodeView> DocumentInvolvementDimcodeViews { get; set; }

    public virtual DbSet<DocumentStatusDim> DocumentStatusDims { get; set; }

    public virtual DbSet<DocumentStatusDimcodeView> DocumentStatusDimcodeViews { get; set; }

    public virtual DbSet<DocumentView> DocumentViews { get; set; }

    public virtual DbSet<DriverDataConfiscationLog> DriverDataConfiscationLogs { get; set; }

    public virtual DbSet<DriverDatum> DriverData { get; set; }

    public virtual DbSet<DriverDrinkingStatusDim> DriverDrinkingStatusDims { get; set; }

    public virtual DbSet<DriverLicenseCivilianClassDim> DriverLicenseCivilianClassDims { get; set; }

    public virtual DbSet<DriverLicenseCivilianClassDimcodeView> DriverLicenseCivilianClassDimcodeViews { get; set; }

    public virtual DbSet<DriverLicenseCommericalClassDim> DriverLicenseCommericalClassDims { get; set; }

    public virtual DbSet<DriverLicenseCommericalClassDimcodeView> DriverLicenseCommericalClassDimcodeViews { get; set; }

    public virtual DbSet<DriverLicensePermitStatusDim> DriverLicensePermitStatusDims { get; set; }

    public virtual DbSet<DriverLicensePermitStatusDimcodeView> DriverLicensePermitStatusDimcodeViews { get; set; }

    public virtual DbSet<DriverStatusDim> DriverStatusDims { get; set; }

    public virtual DbSet<DrivingAccidentSeverityDim> DrivingAccidentSeverityDims { get; set; }

    public virtual DbSet<DrivingAccidentSeverityDimcodeView> DrivingAccidentSeverityDimcodeViews { get; set; }

    public virtual DbSet<DrivingCmvdim> DrivingCmvdims { get; set; }

    public virtual DbSet<DrivingCmvdimcodeView> DrivingCmvdimcodeViews { get; set; }

    public virtual DbSet<DrivingHazMatDim> DrivingHazMatDims { get; set; }

    public virtual DbSet<DrivingHazMatDimcodeView> DrivingHazMatDimcodeViews { get; set; }

    public virtual DbSet<DrivingIncident> DrivingIncidents { get; set; }

    public virtual DbSet<DrivingRoadCategoryDim> DrivingRoadCategoryDims { get; set; }

    public virtual DbSet<DrivingRoadCategoryDimcodeView> DrivingRoadCategoryDimcodeViews { get; set; }

    public virtual DbSet<DrivingRoadConditionDim> DrivingRoadConditionDims { get; set; }

    public virtual DbSet<DrivingRoadConditionDimcodeView> DrivingRoadConditionDimcodeViews { get; set; }

    public virtual DbSet<DrivingTrafficConditionDim> DrivingTrafficConditionDims { get; set; }

    public virtual DbSet<DrivingTrafficConditionDimcodeView> DrivingTrafficConditionDimcodeViews { get; set; }

    public virtual DbSet<DrivingWeatherConditionDim> DrivingWeatherConditionDims { get; set; }

    public virtual DbSet<DrivingWeatherConditionDimcodeView> DrivingWeatherConditionDimcodeViews { get; set; }

    public virtual DbSet<Drug> Drugs { get; set; }

    public virtual DbSet<DrugCategoryDim> DrugCategoryDims { get; set; }

    public virtual DbSet<DrugCategoryDimcodeView> DrugCategoryDimcodeViews { get; set; }

    public virtual DbSet<DrugCompositionDim> DrugCompositionDims { get; set; }

    public virtual DbSet<DrugCompositionDimcodeView> DrugCompositionDimcodeViews { get; set; }

    public virtual DbSet<DrugContainerDim> DrugContainerDims { get; set; }

    public virtual DbSet<DrugContainerDimcodeView> DrugContainerDimcodeViews { get; set; }

    public virtual DbSet<DrugFoundDim> DrugFoundDims { get; set; }

    public virtual DbSet<DrugFoundDimcodeView> DrugFoundDimcodeViews { get; set; }

    public virtual DbSet<DrugGuidView> DrugGuidViews { get; set; }

    public virtual DbSet<DrugSubstanceFormDim> DrugSubstanceFormDims { get; set; }

    public virtual DbSet<DrugSubstanceFormDimcodeView> DrugSubstanceFormDimcodeViews { get; set; }

    public virtual DbSet<DrugView> DrugViews { get; set; }

    public virtual DbSet<DtoTypeDim> DtoTypeDims { get; set; }

    public virtual DbSet<EducationCategoryDim> EducationCategoryDims { get; set; }

    public virtual DbSet<EducationCategoryDimcodeView> EducationCategoryDimcodeViews { get; set; }

    public virtual DbSet<EducationDegreeDim> EducationDegreeDims { get; set; }

    public virtual DbSet<EducationDegreeDimcodeView> EducationDegreeDimcodeViews { get; set; }

    public virtual DbSet<EducationSchedule> EducationSchedules { get; set; }

    public virtual DbSet<EducationScheduleDayDim> EducationScheduleDayDims { get; set; }

    public virtual DbSet<EducationScheduleDayDimcodeView> EducationScheduleDayDimcodeViews { get; set; }

    public virtual DbSet<EducationScheduleGuidView> EducationScheduleGuidViews { get; set; }

    public virtual DbSet<EducationScheduleView> EducationScheduleViews { get; set; }

    public virtual DbSet<EducationStatusDim> EducationStatusDims { get; set; }

    public virtual DbSet<EducationStatusDimcodeView> EducationStatusDimcodeViews { get; set; }

    public virtual DbSet<ElectronicInspectionAnswer> ElectronicInspectionAnswers { get; set; }

    public virtual DbSet<ElectronicInspectionPatrolAttendance> ElectronicInspectionPatrolAttendances { get; set; }

    public virtual DbSet<ElectronicInspectionQuestion> ElectronicInspectionQuestions { get; set; }

    public virtual DbSet<ElectronicInspectionReport> ElectronicInspectionReports { get; set; }

    public virtual DbSet<ElectronicInspectionReportAnswer> ElectronicInspectionReportAnswers { get; set; }

    public virtual DbSet<ElectronicInspectionReportAnswerLog> ElectronicInspectionReportAnswerLogs { get; set; }

    public virtual DbSet<ElectronicInspectionReportAnswerStatus> ElectronicInspectionReportAnswerStatuses { get; set; }

    public virtual DbSet<ElectronicInspectionReportDamagePart> ElectronicInspectionReportDamageParts { get; set; }

    public virtual DbSet<ElectronicInspectionReportDamagePartslog> ElectronicInspectionReportDamagePartslogs { get; set; }

    public virtual DbSet<ElectronicInspectionReportDocument> ElectronicInspectionReportDocuments { get; set; }

    public virtual DbSet<ElectronicInspectionReportFmsrequest> ElectronicInspectionReportFmsrequests { get; set; }

    public virtual DbSet<ElectronicInspectionReportGroup> ElectronicInspectionReportGroups { get; set; }

    public virtual DbSet<ElectronicInspectionReportLog> ElectronicInspectionReportLogs { get; set; }

    public virtual DbSet<ElectronicInspectionReportSentToFmsrequest> ElectronicInspectionReportSentToFmsrequests { get; set; }

    public virtual DbSet<ElectronicInspectionReportStatus> ElectronicInspectionReportStatuses { get; set; }

    public virtual DbSet<ElectronicInspectionReportUser> ElectronicInspectionReportUsers { get; set; }

    public virtual DbSet<ElectronicInspectionRole> ElectronicInspectionRoles { get; set; }

    public virtual DbSet<ElectronicInspectionUserView> ElectronicInspectionUserViews { get; set; }

    public virtual DbSet<ElectronicSignature> ElectronicSignatures { get; set; }

    public virtual DbSet<EmirateArea> EmirateAreas { get; set; }

    public virtual DbSet<EmirateDim> EmirateDims { get; set; }

    public virtual DbSet<EmirateDimToAreaMapping> EmirateDimToAreaMappings { get; set; }

    public virtual DbSet<EmirateView> EmirateViews { get; set; }

    public virtual DbSet<EmploymentDepartmentDim> EmploymentDepartmentDims { get; set; }

    public virtual DbSet<EmploymentDepartmentDimcodeView> EmploymentDepartmentDimcodeViews { get; set; }

    public virtual DbSet<EmploymentOccupationDim> EmploymentOccupationDims { get; set; }

    public virtual DbSet<EmploymentOccupationDimcodeView> EmploymentOccupationDimcodeViews { get; set; }

    public virtual DbSet<EmploymentPositionDim> EmploymentPositionDims { get; set; }

    public virtual DbSet<EmploymentPositionDimcodeView> EmploymentPositionDimcodeViews { get; set; }

    public virtual DbSet<EmploymentRankDim> EmploymentRankDims { get; set; }

    public virtual DbSet<EmploymentRankDimcodeView> EmploymentRankDimcodeViews { get; set; }

    public virtual DbSet<EmploymentStatusDim> EmploymentStatusDims { get; set; }

    public virtual DbSet<EmploymentStatusDimcodeView> EmploymentStatusDimcodeViews { get; set; }

    public virtual DbSet<EmploymentWorkShiftDim> EmploymentWorkShiftDims { get; set; }

    public virtual DbSet<EmploymentWorkShiftDimcodeView> EmploymentWorkShiftDimcodeViews { get; set; }

    public virtual DbSet<EnforcementOfficial> EnforcementOfficials { get; set; }

    public virtual DbSet<EnforcementOfficialAsnCategoryDim> EnforcementOfficialAsnCategoryDims { get; set; }

    public virtual DbSet<EnforcementOfficialAsnCategoryDimcodeView> EnforcementOfficialAsnCategoryDimcodeViews { get; set; }

    public virtual DbSet<EnforcementOfficialCategoryDim> EnforcementOfficialCategoryDims { get; set; }

    public virtual DbSet<EnforcementOfficialCategoryDimcodeView> EnforcementOfficialCategoryDimcodeViews { get; set; }

    public virtual DbSet<EnforcementOfficialGuidView> EnforcementOfficialGuidViews { get; set; }

    public virtual DbSet<EnforcementOfficialView> EnforcementOfficialViews { get; set; }

    public virtual DbSet<Entity> Entities { get; set; }

    public virtual DbSet<ErrEnvolvedLog> ErrEnvolvedLogs { get; set; }

    public virtual DbSet<EsAttachment> EsAttachments { get; set; }

    public virtual DbSet<EsConditionDim> EsConditionDims { get; set; }

    public virtual DbSet<EsInput> EsInputs { get; set; }

    public virtual DbSet<EsInputTypeDim> EsInputTypeDims { get; set; }

    public virtual DbSet<EsInsuranceInquiryResult> EsInsuranceInquiryResults { get; set; }

    public virtual DbSet<EsMobileVerification> EsMobileVerifications { get; set; }

    public virtual DbSet<EsRepairPermission> EsRepairPermissions { get; set; }

    public virtual DbSet<EsRepairPermissionCountriesDim> EsRepairPermissionCountriesDims { get; set; }

    public virtual DbSet<EsRepairPermissionDamagedPart> EsRepairPermissionDamagedParts { get; set; }

    public virtual DbSet<EsRepairPermissionStatus> EsRepairPermissionStatuses { get; set; }

    public virtual DbSet<EsRepairPermissionTypeDim> EsRepairPermissionTypeDims { get; set; }

    public virtual DbSet<EsService> EsServices { get; set; }

    public virtual DbSet<EsStep> EsSteps { get; set; }

    public virtual DbSet<EsUserControlDim> EsUserControlDims { get; set; }

    public virtual DbSet<EsVehicleInquiry> EsVehicleInquiries { get; set; }

    public virtual DbSet<EsVehicleInquiryResult> EsVehicleInquiryResults { get; set; }

    public virtual DbSet<EscapedStatusDim> EscapedStatusDims { get; set; }

    public virtual DbSet<Escort> Escorts { get; set; }

    public virtual DbSet<EscortAttachment> EscortAttachments { get; set; }

    public virtual DbSet<EscortAttachmentTypeDim> EscortAttachmentTypeDims { get; set; }

    public virtual DbSet<EscortCancelationConfirmationReasonDim> EscortCancelationConfirmationReasonDims { get; set; }

    public virtual DbSet<EscortEmailTemplate> EscortEmailTemplates { get; set; }

    public virtual DbSet<EscortInfo> EscortInfos { get; set; }

    public virtual DbSet<EscortMission> EscortMissions { get; set; }

    public virtual DbSet<EscortMissionCancelationLog> EscortMissionCancelationLogs { get; set; }

    public virtual DbSet<EscortMissionEmployee> EscortMissionEmployees { get; set; }

    public virtual DbSet<EscortMissionPatrol> EscortMissionPatrols { get; set; }

    public virtual DbSet<EscortMissionPatrolEmployee> EscortMissionPatrolEmployees { get; set; }

    public virtual DbSet<EscortMissionPatrolStep> EscortMissionPatrolSteps { get; set; }

    public virtual DbSet<EscortMissionStep> EscortMissionSteps { get; set; }

    public virtual DbSet<EscortRejectionReasonDim> EscortRejectionReasonDims { get; set; }

    public virtual DbSet<EscortRequestStep> EscortRequestSteps { get; set; }

    public virtual DbSet<EscortTypeDim> EscortTypeDims { get; set; }

    public virtual DbSet<EscortVehicle> EscortVehicles { get; set; }

    public virtual DbSet<EscortingIntegrationTokenLog> EscortingIntegrationTokenLogs { get; set; }

    public virtual DbSet<EscortingReportBasicDetail> EscortingReportBasicDetails { get; set; }

    public virtual DbSet<EservicesSupervisor> EservicesSupervisors { get; set; }

    public virtual DbSet<EthnicityDim> EthnicityDims { get; set; }

    public virtual DbSet<EthnicityDimcodeView> EthnicityDimcodeViews { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventIncident> EventIncidents { get; set; }

    public virtual DbSet<EventIncidentAction> EventIncidentActions { get; set; }

    public virtual DbSet<EventIncidentActionDim> EventIncidentActionDims { get; set; }

    public virtual DbSet<EventIncidentComment> EventIncidentComments { get; set; }

    public virtual DbSet<EventIncidentCriticalityLevelDim> EventIncidentCriticalityLevelDims { get; set; }

    public virtual DbSet<EventIncidentImage> EventIncidentImages { get; set; }

    public virtual DbSet<EventIncidentPerson> EventIncidentPeople { get; set; }

    public virtual DbSet<EventIncidentStatusDim> EventIncidentStatusDims { get; set; }

    public virtual DbSet<EventIncidentSubTypeDim> EventIncidentSubTypeDims { get; set; }

    public virtual DbSet<EventIncidentTypeDim> EventIncidentTypeDims { get; set; }

    public virtual DbSet<EventIncidentVehicle> EventIncidentVehicles { get; set; }

    public virtual DbSet<EventIncidentsLog> EventIncidentsLogs { get; set; }

    public virtual DbSet<EventIncidentsStatusLog> EventIncidentsStatusLogs { get; set; }

    public virtual DbSet<EventMissionAcceptanceStatusDim> EventMissionAcceptanceStatusDims { get; set; }

    public virtual DbSet<EventMissionAssignmentLog> EventMissionAssignmentLogs { get; set; }

    public virtual DbSet<EventMissionAssignmentStatusDim> EventMissionAssignmentStatusDims { get; set; }

    public virtual DbSet<EventSourcePerson> EventSourcePersons { get; set; }

    public virtual DbSet<EventTypeDim> EventTypeDims { get; set; }

    public virtual DbSet<EventsArea> EventsAreas { get; set; }

    public virtual DbSet<EventsAttendanceLogStatusDim> EventsAttendanceLogStatusDims { get; set; }

    public virtual DbSet<EventsAttendanceTypeDim> EventsAttendanceTypeDims { get; set; }

    public virtual DbSet<EventsEmployeeTypeDim> EventsEmployeeTypeDims { get; set; }

    public virtual DbSet<EventsEmployeesAttendance> EventsEmployeesAttendances { get; set; }

    public virtual DbSet<EventsEmployeesAttendanceLog> EventsEmployeesAttendanceLogs { get; set; }

    public virtual DbSet<EventsIntegrationTokenLog> EventsIntegrationTokenLogs { get; set; }

    public virtual DbSet<EventsMission> EventsMissions { get; set; }

    public virtual DbSet<EventsMissionAssignment> EventsMissionAssignments { get; set; }

    public virtual DbSet<EventsMissionAssignmentNotification> EventsMissionAssignmentNotifications { get; set; }

    public virtual DbSet<EventsMissionLevelDim> EventsMissionLevelDims { get; set; }

    public virtual DbSet<EventsMissionStatusDim> EventsMissionStatusDims { get; set; }

    public virtual DbSet<EventsMissionTypeDim> EventsMissionTypeDims { get; set; }

    public virtual DbSet<EventsMissionsStatusLog> EventsMissionsStatusLogs { get; set; }

    public virtual DbSet<EventsMissionsType> EventsMissionsTypes { get; set; }

    public virtual DbSet<EventsOvertimeReport> EventsOvertimeReports { get; set; }

    public virtual DbSet<EventsOvertimeReportBackup> EventsOvertimeReportBackups { get; set; }

    public virtual DbSet<EventsOvertimeReportConfiguration> EventsOvertimeReportConfigurations { get; set; }

    public virtual DbSet<EventsPatrol> EventsPatrols { get; set; }

    public virtual DbSet<EventsPerson> EventsPersons { get; set; }

    public virtual DbSet<EventsPersonJobTypeDim> EventsPersonJobTypeDims { get; set; }

    public virtual DbSet<EventsSourceDim> EventsSourceDims { get; set; }

    public virtual DbSet<EventsStatusDim> EventsStatusDims { get; set; }

    public virtual DbSet<EventsStatusLog> EventsStatusLogs { get; set; }

    public virtual DbSet<EventsSupervisor> EventsSupervisors { get; set; }

    public virtual DbSet<EvgPaymentStatusDim> EvgPaymentStatusDims { get; set; }

    public virtual DbSet<Evidence> Evidences { get; set; }

    public virtual DbSet<EvidenceGuidView> EvidenceGuidViews { get; set; }

    public virtual DbSet<EvidenceView> EvidenceViews { get; set; }

    public virtual DbSet<ExtendedActivityEventsTable> ExtendedActivityEventsTables { get; set; }

    public virtual DbSet<ExternalUserPasswordChangeHistory> ExternalUserPasswordChangeHistories { get; set; }

    public virtual DbSet<Facility> Facilities { get; set; }

    public virtual DbSet<FacilityBedAssignmentDim> FacilityBedAssignmentDims { get; set; }

    public virtual DbSet<FacilityBedAssignmentDimcodeView> FacilityBedAssignmentDimcodeViews { get; set; }

    public virtual DbSet<FacilityCategoryDim> FacilityCategoryDims { get; set; }

    public virtual DbSet<FacilityCategoryDimcodeView> FacilityCategoryDimcodeViews { get; set; }

    public virtual DbSet<FacilityGuidView> FacilityGuidViews { get; set; }

    public virtual DbSet<FacilityMemberCategoryDim> FacilityMemberCategoryDims { get; set; }

    public virtual DbSet<FacilityMemberCategoryDimcodeView> FacilityMemberCategoryDimcodeViews { get; set; }

    public virtual DbSet<FacilitySecurityLevelDim> FacilitySecurityLevelDims { get; set; }

    public virtual DbSet<FacilitySecurityLevelDimcodeView> FacilitySecurityLevelDimcodeViews { get; set; }

    public virtual DbSet<FacilityView> FacilityViews { get; set; }

    public virtual DbSet<FieldsFactorDim> FieldsFactorDims { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<FileCategoryDim> FileCategoryDims { get; set; }

    public virtual DbSet<FinancialReportHelper> FinancialReportHelpers { get; set; }

    public virtual DbSet<FingerPrintPatternCategoryDim> FingerPrintPatternCategoryDims { get; set; }

    public virtual DbSet<FingerPrintPatternCategoryDimcodeView> FingerPrintPatternCategoryDimcodeViews { get; set; }

    public virtual DbSet<FingerPrintPatternClassificationDim> FingerPrintPatternClassificationDims { get; set; }

    public virtual DbSet<FingerPrintPatternClassificationDimcodeView> FingerPrintPatternClassificationDimcodeViews { get; set; }

    public virtual DbSet<FingerprintFingerDim> FingerprintFingerDims { get; set; }

    public virtual DbSet<FingerprintFingerDimcodeView> FingerprintFingerDimcodeViews { get; set; }

    public virtual DbSet<Firearm> Firearms { get; set; }

    public virtual DbSet<FirearmActionCategoryDim> FirearmActionCategoryDims { get; set; }

    public virtual DbSet<FirearmActionCategoryDimcodeView> FirearmActionCategoryDimcodeViews { get; set; }

    public virtual DbSet<FirearmCategoryDim> FirearmCategoryDims { get; set; }

    public virtual DbSet<FirearmCategoryDimcodeView> FirearmCategoryDimcodeViews { get; set; }

    public virtual DbSet<FirearmFinishDim> FirearmFinishDims { get; set; }

    public virtual DbSet<FirearmFinishDimcodeView> FirearmFinishDimcodeViews { get; set; }

    public virtual DbSet<FirearmGageCaliberDim> FirearmGageCaliberDims { get; set; }

    public virtual DbSet<FirearmGageCaliberDimcodeView> FirearmGageCaliberDimcodeViews { get; set; }

    public virtual DbSet<FirearmGripDim> FirearmGripDims { get; set; }

    public virtual DbSet<FirearmGripDimcodeView> FirearmGripDimcodeViews { get; set; }

    public virtual DbSet<FirearmGuidView> FirearmGuidViews { get; set; }

    public virtual DbSet<FirearmView> FirearmViews { get; set; }

    public virtual DbSet<FmsbranchOrder> FmsbranchOrders { get; set; }

    public virtual DbSet<FmsbranchUser> FmsbranchUsers { get; set; }

    public virtual DbSet<FmsexcludedBranch> FmsexcludedBranches { get; set; }

    public virtual DbSet<FmssubBranchUser> FmssubBranchUsers { get; set; }

    public virtual DbSet<GenderDim> GenderDims { get; set; }

    public virtual DbSet<GeneralUnstatisfiedSurveyView> GeneralUnstatisfiedSurveyViews { get; set; }

    public virtual DbSet<GeoCensusTractDim> GeoCensusTractDims { get; set; }

    public virtual DbSet<GeoCensusTractDimcodeView> GeoCensusTractDimcodeViews { get; set; }

    public virtual DbSet<GeoCityDim> GeoCityDims { get; set; }

    public virtual DbSet<GeoCityDimcodeView> GeoCityDimcodeViews { get; set; }

    public virtual DbSet<GeoCountryDim> GeoCountryDims { get; set; }

    public virtual DbSet<GeoCountryDimcodeView> GeoCountryDimcodeViews { get; set; }

    public virtual DbSet<GeoCountyDim> GeoCountyDims { get; set; }

    public virtual DbSet<GeoCountyDimcodeView> GeoCountyDimcodeViews { get; set; }

    public virtual DbSet<GeoLeodim> GeoLeodims { get; set; }

    public virtual DbSet<GeoLeodimcodeView> GeoLeodimcodeViews { get; set; }

    public virtual DbSet<GeoLocationSubDivisionDim> GeoLocationSubDivisionDims { get; set; }

    public virtual DbSet<GeoLocationSubDivisionDimcodeView> GeoLocationSubDivisionDimcodeViews { get; set; }

    public virtual DbSet<GeoStateDim> GeoStateDims { get; set; }

    public virtual DbSet<GeoStateDimcodeView> GeoStateDimcodeViews { get; set; }

    public virtual DbSet<GeoZipDim> GeoZipDims { get; set; }

    public virtual DbSet<GeoZipDimcodeView> GeoZipDimcodeViews { get; set; }

    public virtual DbSet<GetAccidentDetail> GetAccidentDetails { get; set; }

    public virtual DbSet<GetActiveDirectoryPersonsFullDetail> GetActiveDirectoryPersonsFullDetails { get; set; }

    public virtual DbSet<GetAreaCenter> GetAreaCenters { get; set; }

    public virtual DbSet<GetAreaToBeAddedAutoDispatch> GetAreaToBeAddedAutoDispatches { get; set; }

    public virtual DbSet<GetAreaToBeAddedDetectLocation> GetAreaToBeAddedDetectLocations { get; set; }

    public virtual DbSet<GetAutoDispatchAreaDetail> GetAutoDispatchAreaDetails { get; set; }

    public virtual DbSet<GetCreateAccidentCauseDatum> GetCreateAccidentCauseData { get; set; }

    public virtual DbSet<GetCreateAccidentDamagedPartDatum> GetCreateAccidentDamagedPartData { get; set; }

    public virtual DbSet<GetCreateAccidentInvolvedData2> GetCreateAccidentInvolvedData2s { get; set; }

    public virtual DbSet<GetCreateAccidentInvolvedDatum> GetCreateAccidentInvolvedData { get; set; }

    public virtual DbSet<GetCreateAccidentMasterDatum> GetCreateAccidentMasterData { get; set; }

    public virtual DbSet<GetCreateDamagedGovProperty> GetCreateDamagedGovProperties { get; set; }

    public virtual DbSet<GetDetectLocationAreaDetail> GetDetectLocationAreaDetails { get; set; }

    public virtual DbSet<GetDeviceListByRole> GetDeviceListByRoles { get; set; }

    public virtual DbSet<GetFullReportDetailsForMobileUser> GetFullReportDetailsForMobileUsers { get; set; }

    public virtual DbSet<GetFullReportDetailsForMotoriIntegration> GetFullReportDetailsForMotoriIntegrations { get; set; }

    public virtual DbSet<GetFullReportDetailsForMotoriIntegrationAdp> GetFullReportDetailsForMotoriIntegrationAdps { get; set; }

    public virtual DbSet<GetIncidentMapStatus> GetIncidentMapStatuses { get; set; }

    public virtual DbSet<GetLastDaySupportShortDetail> GetLastDaySupportShortDetails { get; set; }

    public virtual DbSet<GetMdtaccidentReportRequiredField> GetMdtaccidentReportRequiredFields { get; set; }

    public virtual DbSet<GetPersonByUserName> GetPersonByUserNames { get; set; }

    public virtual DbSet<GetReportDetailsDatum> GetReportDetailsData { get; set; }

    public virtual DbSet<GlassColorDim> GlassColorDims { get; set; }

    public virtual DbSet<Hash> Hashes { get; set; }

    public virtual DbSet<HeightMeasureUnitDim> HeightMeasureUnitDims { get; set; }

    public virtual DbSet<HeightMeasureUnitDimcodeView> HeightMeasureUnitDimcodeViews { get; set; }

    public virtual DbSet<HighLowDim> HighLowDims { get; set; }

    public virtual DbSet<HighLowDimcodeView> HighLowDimcodeViews { get; set; }

    public virtual DbSet<IcccactivityPersonComment> IcccactivityPersonComments { get; set; }

    public virtual DbSet<IcccgetMdtTeam> IcccgetMdtTeams { get; set; }

    public virtual DbSet<IcccgetMdtVirtualOrganization> IcccgetMdtVirtualOrganizations { get; set; }

    public virtual DbSet<IcccincidentCall> IcccincidentCalls { get; set; }

    public virtual DbSet<IcccincidentItem> IcccincidentItems { get; set; }

    public virtual DbSet<IcccincidentItemFreePatrol> IcccincidentItemFreePatrols { get; set; }

    public virtual DbSet<IcccincidentLog> IcccincidentLogs { get; set; }

    public virtual DbSet<IcccincidentRequest> IcccincidentRequests { get; set; }

    public virtual DbSet<IcccincidentRequestDetail> IcccincidentRequestDetails { get; set; }

    public virtual DbSet<IcccincidentRequestInfo> IcccincidentRequestInfos { get; set; }

    public virtual DbSet<IcccincidentWorkFlow> IcccincidentWorkFlows { get; set; }

    public virtual DbSet<IcccintegrationLog> IcccintegrationLogs { get; set; }

    public virtual DbSet<IcccnewIncidentLog> IcccnewIncidentLogs { get; set; }

    public virtual DbSet<IcccpoliceIncident> IcccpoliceIncidents { get; set; }

    public virtual DbSet<IcccrequestComment> IcccrequestComments { get; set; }

    public virtual DbSet<IcccrequestDispatcher> IcccrequestDispatchers { get; set; }

    public virtual DbSet<IcccrequestStatus> IcccrequestStatuses { get; set; }

    public virtual DbSet<IcccsaaedIncidentMap> IcccsaaedIncidentMaps { get; set; }

    public virtual DbSet<IcccsendReciveLog> IcccsendReciveLogs { get; set; }

    public virtual DbSet<IcccsendRetry> IcccsendRetries { get; set; }

    public virtual DbSet<IcccsharedLookup> IcccsharedLookups { get; set; }

    public virtual DbSet<IcccsharedLookupType> IcccsharedLookupTypes { get; set; }

    public virtual DbSet<IcccsupervisorMissionForTe> IcccsupervisorMissionForTes { get; set; }

    public virtual DbSet<IcccsupervisorSupport> IcccsupervisorSupports { get; set; }

    public virtual DbSet<IcccviewAreaAreaCategoryArea> IcccviewAreaAreaCategoryAreas { get; set; }

    public virtual DbSet<IcccviewAreaAreaCategoryEmira> IcccviewAreaAreaCategoryEmiras { get; set; }

    public virtual DbSet<IcccviewAreaAreaCategoryLandmark> IcccviewAreaAreaCategoryLandmarks { get; set; }

    public virtual DbSet<IcccviewAreaAreaCategorySector> IcccviewAreaAreaCategorySectors { get; set; }

    public virtual DbSet<IcccviewAttendedPatrol> IcccviewAttendedPatrols { get; set; }

    public virtual DbSet<IcccviewAttendedPatrolOfficer> IcccviewAttendedPatrolOfficers { get; set; }

    public virtual DbSet<IcccviewAutomaticIncident> IcccviewAutomaticIncidents { get; set; }

    public virtual DbSet<IcccviewCallerCredibility> IcccviewCallerCredibilities { get; set; }

    public virtual DbSet<IcccviewDispatcherIncidentPatrol> IcccviewDispatcherIncidentPatrols { get; set; }

    public virtual DbSet<IcccviewIncident> IcccviewIncidents { get; set; }

    public virtual DbSet<IcccviewIncidentAssignedPatrol> IcccviewIncidentAssignedPatrols { get; set; }

    public virtual DbSet<IcccviewIncidentCanceledPatrol> IcccviewIncidentCanceledPatrols { get; set; }

    public virtual DbSet<IcccviewIncidentChildDelayStatus> IcccviewIncidentChildDelayStatuses { get; set; }

    public virtual DbSet<IcccviewIncidentDelayStatus> IcccviewIncidentDelayStatuses { get; set; }

    public virtual DbSet<IcccviewIncidentPopupIncident> IcccviewIncidentPopupIncidents { get; set; }

    public virtual DbSet<IcccviewIncidentPopupPatrol> IcccviewIncidentPopupPatrols { get; set; }

    public virtual DbSet<IcccviewIncidentRequest> IcccviewIncidentRequests { get; set; }

    public virtual DbSet<IcccviewIncidentSupportRequest> IcccviewIncidentSupportRequests { get; set; }

    public virtual DbSet<IcccviewLoginChild> IcccviewLoginChildren { get; set; }

    public virtual DbSet<IcccviewOpenIncident> IcccviewOpenIncidents { get; set; }

    public virtual DbSet<IcccviewOpenIncidentDelayStatusHistory> IcccviewOpenIncidentDelayStatusHistories { get; set; }

    public virtual DbSet<IcccviewPatrol> IcccviewPatrols { get; set; }

    public virtual DbSet<IcccviewPatrol2> IcccviewPatrol2s { get; set; }

    public virtual DbSet<IcccviewPatrolDelayStatus> IcccviewPatrolDelayStatuses { get; set; }

    public virtual DbSet<IcccviewPatrolLoggedStatus> IcccviewPatrolLoggedStatuses { get; set; }

    public virtual DbSet<IcccviewPatrolLogoutRequest> IcccviewPatrolLogoutRequests { get; set; }

    public virtual DbSet<IcccviewPatrolLogoutRequestOfficer> IcccviewPatrolLogoutRequestOfficers { get; set; }

    public virtual DbSet<IcccviewPatrolOfficersNotAttended> IcccviewPatrolOfficersNotAttendeds { get; set; }

    public virtual DbSet<IcccviewPatrolOnMission> IcccviewPatrolOnMissions { get; set; }

    public virtual DbSet<IcccviewSourceDetail> IcccviewSourceDetails { get; set; }

    public virtual DbSet<IcccviewSupporCreator> IcccviewSupporCreators { get; set; }

    public virtual DbSet<IcccviweIncidentOrganization> IcccviweIncidentOrganizations { get; set; }

    public virtual DbSet<IdentificationAuthorityDim> IdentificationAuthorityDims { get; set; }

    public virtual DbSet<IdentificationAuthorityDimcodeView> IdentificationAuthorityDimcodeViews { get; set; }

    public virtual DbSet<IdentificationCategoryDim> IdentificationCategoryDims { get; set; }

    public virtual DbSet<IdentificationCategoryDimcodeView> IdentificationCategoryDimcodeViews { get; set; }

    public virtual DbSet<IdentificationClassDim> IdentificationClassDims { get; set; }

    public virtual DbSet<IdentificationClassDimcodeView> IdentificationClassDimcodeViews { get; set; }

    public virtual DbSet<IdentificationRestrictionDim> IdentificationRestrictionDims { get; set; }

    public virtual DbSet<IdentificationRestrictionDimcodeView> IdentificationRestrictionDimcodeViews { get; set; }

    public virtual DbSet<IdentificationtStatusDim> IdentificationtStatusDims { get; set; }

    public virtual DbSet<IdentificationtStatusDimcodeView> IdentificationtStatusDimcodeViews { get; set; }

    public virtual DbSet<IdentityTheftCategoryDim> IdentityTheftCategoryDims { get; set; }

    public virtual DbSet<IdentityTheftCategoryDimcodeView> IdentityTheftCategoryDimcodeViews { get; set; }

    public virtual DbSet<IdentityTheftIncident> IdentityTheftIncidents { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<ImageCategoryDim> ImageCategoryDims { get; set; }

    public virtual DbSet<ImageCategoryDimcodeView> ImageCategoryDimcodeViews { get; set; }

    public virtual DbSet<ImageFormatDim> ImageFormatDims { get; set; }

    public virtual DbSet<ImageFormatDimcodeView> ImageFormatDimcodeViews { get; set; }

    public virtual DbSet<ImageGuidView> ImageGuidViews { get; set; }

    public virtual DbSet<ImageInvolvementDim> ImageInvolvementDims { get; set; }

    public virtual DbSet<ImageInvolvementDimcodeView> ImageInvolvementDimcodeViews { get; set; }

    public virtual DbSet<ImageView> ImageViews { get; set; }

    public virtual DbSet<ImpactLevelDim> ImpactLevelDims { get; set; }

    public virtual DbSet<ImpactTypeDim> ImpactTypeDims { get; set; }

    public virtual DbSet<ImpoundApitoken> ImpoundApitokens { get; set; }

    public virtual DbSet<ImpoundAuthority> ImpoundAuthorities { get; set; }

    public virtual DbSet<ImpoundOrder> ImpoundOrders { get; set; }

    public virtual DbSet<ImpoundOrderImage> ImpoundOrderImages { get; set; }

    public virtual DbSet<ImpoundOrderStatus> ImpoundOrderStatuses { get; set; }

    public virtual DbSet<ImpoundOrderVehicle> ImpoundOrderVehicles { get; set; }

    public virtual DbSet<ImpoundOrderVehicleDispatch> ImpoundOrderVehicleDispatches { get; set; }

    public virtual DbSet<ImpoundOrdersOpenedView> ImpoundOrdersOpenedViews { get; set; }

    public virtual DbSet<ImpoundPatrolIdMapping> ImpoundPatrolIdMappings { get; set; }

    public virtual DbSet<ImpoundPersonIdMapping> ImpoundPersonIdMappings { get; set; }

    public virtual DbSet<ImpoundPriority> ImpoundPriorities { get; set; }

    public virtual DbSet<ImpoundReason> ImpoundReasons { get; set; }

    public virtual DbSet<ImpoundToken> ImpoundTokens { get; set; }

    public virtual DbSet<IncdentBisync> IncdentBisyncs { get; set; }

    public virtual DbSet<Incident> Incidents { get; set; }

    public virtual DbSet<IncidentActivityCategoryDim> IncidentActivityCategoryDims { get; set; }

    public virtual DbSet<IncidentActivityCategoryDimcodeView> IncidentActivityCategoryDimcodeViews { get; set; }

    public virtual DbSet<IncidentArcfullDetail> IncidentArcfullDetails { get; set; }

    public virtual DbSet<IncidentCategory> IncidentCategories { get; set; }

    public virtual DbSet<IncidentCategoryStatus> IncidentCategoryStatuses { get; set; }

    public virtual DbSet<IncidentCategoryTypeAssociation> IncidentCategoryTypeAssociations { get; set; }

    public virtual DbSet<IncidentExceptionalClearanceDim> IncidentExceptionalClearanceDims { get; set; }

    public virtual DbSet<IncidentExceptionalClearanceDimcodeView> IncidentExceptionalClearanceDimcodeViews { get; set; }

    public virtual DbSet<IncidentFactor> IncidentFactors { get; set; }

    public virtual DbSet<IncidentFactorDim> IncidentFactorDims { get; set; }

    public virtual DbSet<IncidentFactorDimcodeView> IncidentFactorDimcodeViews { get; set; }

    public virtual DbSet<IncidentFactorGuidView> IncidentFactorGuidViews { get; set; }

    public virtual DbSet<IncidentFactorView> IncidentFactorViews { get; set; }

    public virtual DbSet<IncidentForceLevelDim> IncidentForceLevelDims { get; set; }

    public virtual DbSet<IncidentForceLevelDimcodeView> IncidentForceLevelDimcodeViews { get; set; }

    public virtual DbSet<IncidentLaneDim> IncidentLaneDims { get; set; }

    public virtual DbSet<IncidentLevelDim> IncidentLevelDims { get; set; }

    public virtual DbSet<IncidentLevelDimcodeView> IncidentLevelDimcodeViews { get; set; }

    public virtual DbSet<IncidentMethodDim> IncidentMethodDims { get; set; }

    public virtual DbSet<IncidentMethodDimcodeView> IncidentMethodDimcodeViews { get; set; }

    public virtual DbSet<IncidentRequestNotificationView> IncidentRequestNotificationViews { get; set; }

    public virtual DbSet<IncidentReturnToOrreasonsDim> IncidentReturnToOrreasonsDims { get; set; }

    public virtual DbSet<IncidentStatute> IncidentStatutes { get; set; }

    public virtual DbSet<IncidentStatuteGuidView> IncidentStatuteGuidViews { get; set; }

    public virtual DbSet<IncidentStatuteView> IncidentStatuteViews { get; set; }

    public virtual DbSet<IncidentTimesHelp> IncidentTimesHelps { get; set; }

    public virtual DbSet<IncidentsFullDetail> IncidentsFullDetails { get; set; }

    public virtual DbSet<IncidentsMapReportTemplate> IncidentsMapReportTemplates { get; set; }

    public virtual DbSet<InsuranceCompanyDim> InsuranceCompanyDims { get; set; }

    public virtual DbSet<InsuranceCompanyWhiteListDim> InsuranceCompanyWhiteListDims { get; set; }

    public virtual DbSet<InsuranceTypeDim> InsuranceTypeDims { get; set; }

    public virtual DbSet<IntegrationTokenLog> IntegrationTokenLogs { get; set; }

    public virtual DbSet<InternalUserPasswordChangeHistory> InternalUserPasswordChangeHistories { get; set; }

    public virtual DbSet<IntersectionDim> IntersectionDims { get; set; }

    public virtual DbSet<IntoxicationIntoxicantCategoryDim> IntoxicationIntoxicantCategoryDims { get; set; }

    public virtual DbSet<IntoxicationIntoxicantCategoryDimcodeView> IntoxicationIntoxicantCategoryDimcodeViews { get; set; }

    public virtual DbSet<IntoxicationLevelDim> IntoxicationLevelDims { get; set; }

    public virtual DbSet<IntoxicationLevelDimcodeView> IntoxicationLevelDimcodeViews { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemAlias> ItemAliases { get; set; }

    public virtual DbSet<ItemAliasGuidView> ItemAliasGuidViews { get; set; }

    public virtual DbSet<ItemAliasView> ItemAliasViews { get; set; }

    public virtual DbSet<ItemCategoryDim> ItemCategoryDims { get; set; }

    public virtual DbSet<ItemCategoryDimcodeView> ItemCategoryDimcodeViews { get; set; }

    public virtual DbSet<ItemColorDim> ItemColorDims { get; set; }

    public virtual DbSet<ItemColorDimcodeView> ItemColorDimcodeViews { get; set; }

    public virtual DbSet<ItemComment> ItemComments { get; set; }

    public virtual DbSet<ItemCommentContainerGuidView> ItemCommentContainerGuidViews { get; set; }

    public virtual DbSet<ItemCommentContainerView> ItemCommentContainerViews { get; set; }

    public virtual DbSet<ItemCommentGuidView> ItemCommentGuidViews { get; set; }

    public virtual DbSet<ItemCommentView> ItemCommentViews { get; set; }

    public virtual DbSet<ItemConditionDim> ItemConditionDims { get; set; }

    public virtual DbSet<ItemConditionDimcodeView> ItemConditionDimcodeViews { get; set; }

    public virtual DbSet<ItemDocument> ItemDocuments { get; set; }

    public virtual DbSet<ItemDocumentContainerGuidView> ItemDocumentContainerGuidViews { get; set; }

    public virtual DbSet<ItemDocumentContainerView> ItemDocumentContainerViews { get; set; }

    public virtual DbSet<ItemDocumentGuidView> ItemDocumentGuidViews { get; set; }

    public virtual DbSet<ItemDocumentView> ItemDocumentViews { get; set; }

    public virtual DbSet<ItemGuidView> ItemGuidViews { get; set; }

    public virtual DbSet<ItemIdentifier> ItemIdentifiers { get; set; }

    public virtual DbSet<ItemIdentifierDistinctiveMarkingDim> ItemIdentifierDistinctiveMarkingDims { get; set; }

    public virtual DbSet<ItemIdentifierDistinctiveMarkingDimcodeView> ItemIdentifierDistinctiveMarkingDimcodeViews { get; set; }

    public virtual DbSet<ItemIdentifierGuidView> ItemIdentifierGuidViews { get; set; }

    public virtual DbSet<ItemIdentifierLocationDim> ItemIdentifierLocationDims { get; set; }

    public virtual DbSet<ItemIdentifierLocationDimcodeView> ItemIdentifierLocationDimcodeViews { get; set; }

    public virtual DbSet<ItemIdentifierView> ItemIdentifierViews { get; set; }

    public virtual DbSet<ItemImage> ItemImages { get; set; }

    public virtual DbSet<ItemImageContainerGuidView> ItemImageContainerGuidViews { get; set; }

    public virtual DbSet<ItemImageContainerView> ItemImageContainerViews { get; set; }

    public virtual DbSet<ItemImageGuidView> ItemImageGuidViews { get; set; }

    public virtual DbSet<ItemImageView> ItemImageViews { get; set; }

    public virtual DbSet<ItemInvolvementDim> ItemInvolvementDims { get; set; }

    public virtual DbSet<ItemInvolvementDimcodeView> ItemInvolvementDimcodeViews { get; set; }

    public virtual DbSet<ItemLocation> ItemLocations { get; set; }

    public virtual DbSet<ItemLocationContainerGuidView> ItemLocationContainerGuidViews { get; set; }

    public virtual DbSet<ItemLocationContainerView> ItemLocationContainerViews { get; set; }

    public virtual DbSet<ItemMakeModelDim> ItemMakeModelDims { get; set; }

    public virtual DbSet<ItemMakeModelDimcodeView> ItemMakeModelDimcodeViews { get; set; }

    public virtual DbSet<ItemManufactoryDim> ItemManufactoryDims { get; set; }

    public virtual DbSet<ItemQuestionnaireContainerGuidView> ItemQuestionnaireContainerGuidViews { get; set; }

    public virtual DbSet<ItemQuestionnaireGuidView> ItemQuestionnaireGuidViews { get; set; }

    public virtual DbSet<ItemQuestionnaireView> ItemQuestionnaireViews { get; set; }

    public virtual DbSet<ItemRegistration> ItemRegistrations { get; set; }

    public virtual DbSet<ItemRegistrationAuthorityDim> ItemRegistrationAuthorityDims { get; set; }

    public virtual DbSet<ItemRegistrationAuthorityDimcodeView> ItemRegistrationAuthorityDimcodeViews { get; set; }

    public virtual DbSet<ItemRegistrationGuidView> ItemRegistrationGuidViews { get; set; }

    public virtual DbSet<ItemRegistrationJurisdictionDim> ItemRegistrationJurisdictionDims { get; set; }

    public virtual DbSet<ItemRegistrationJurisdictionDimcodeView> ItemRegistrationJurisdictionDimcodeViews { get; set; }

    public virtual DbSet<ItemRegistrationPlateCategoryDim> ItemRegistrationPlateCategoryDims { get; set; }

    public virtual DbSet<ItemRegistrationPlateCategoryDimcodeView> ItemRegistrationPlateCategoryDimcodeViews { get; set; }

    public virtual DbSet<ItemRegistrationPlateCodeDim> ItemRegistrationPlateCodeDims { get; set; }

    public virtual DbSet<ItemRegistrationPlateCodeDimcodeView> ItemRegistrationPlateCodeDimcodeViews { get; set; }

    public virtual DbSet<ItemRegistrationPlateColorDim> ItemRegistrationPlateColorDims { get; set; }

    public virtual DbSet<ItemRegistrationPlateKindDim> ItemRegistrationPlateKindDims { get; set; }

    public virtual DbSet<ItemRegistrationPlateKindDimcodeView> ItemRegistrationPlateKindDimcodeViews { get; set; }

    public virtual DbSet<ItemRegistrationView> ItemRegistrationViews { get; set; }

    public virtual DbSet<ItemStatusDim> ItemStatusDims { get; set; }

    public virtual DbSet<ItemStatusDimcodeView> ItemStatusDimcodeViews { get; set; }

    public virtual DbSet<ItemUsageDim> ItemUsageDims { get; set; }

    public virtual DbSet<ItemUsageDimcodeView> ItemUsageDimcodeViews { get; set; }

    public virtual DbSet<ItemView> ItemViews { get; set; }

    public virtual DbSet<Jewelry> Jewelries { get; set; }

    public virtual DbSet<JewelryCaratDim> JewelryCaratDims { get; set; }

    public virtual DbSet<JewelryCaratDimcodeView> JewelryCaratDimcodeViews { get; set; }

    public virtual DbSet<JewelryCategoryDim> JewelryCategoryDims { get; set; }

    public virtual DbSet<JewelryCategoryDimcodeView> JewelryCategoryDimcodeViews { get; set; }

    public virtual DbSet<JewelryGenderDim> JewelryGenderDims { get; set; }

    public virtual DbSet<JewelryGenderDimcodeView> JewelryGenderDimcodeViews { get; set; }

    public virtual DbSet<JewelryGuidView> JewelryGuidViews { get; set; }

    public virtual DbSet<JewelryMetalTypeDim> JewelryMetalTypeDims { get; set; }

    public virtual DbSet<JewelryMetalTypeDimcodeView> JewelryMetalTypeDimcodeViews { get; set; }

    public virtual DbSet<JewelryStone> JewelryStones { get; set; }

    public virtual DbSet<JewelryStoneCaratDim> JewelryStoneCaratDims { get; set; }

    public virtual DbSet<JewelryStoneCaratDimcodeView> JewelryStoneCaratDimcodeViews { get; set; }

    public virtual DbSet<JewelryStoneCategoryDim> JewelryStoneCategoryDims { get; set; }

    public virtual DbSet<JewelryStoneCategoryDimcodeView> JewelryStoneCategoryDimcodeViews { get; set; }

    public virtual DbSet<JewelryStoneCutDim> JewelryStoneCutDims { get; set; }

    public virtual DbSet<JewelryStoneCutDimcodeView> JewelryStoneCutDimcodeViews { get; set; }

    public virtual DbSet<JewelryStoneGuidView> JewelryStoneGuidViews { get; set; }

    public virtual DbSet<JewelryStoneView> JewelryStoneViews { get; set; }

    public virtual DbSet<JewelryStyleDim> JewelryStyleDims { get; set; }

    public virtual DbSet<JewelryStyleDimcodeView> JewelryStyleDimcodeViews { get; set; }

    public virtual DbSet<JewelryView> JewelryViews { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobParameter> JobParameters { get; set; }

    public virtual DbSet<JobQueue> JobQueues { get; set; }

    public virtual DbSet<JudicialOfficial> JudicialOfficials { get; set; }

    public virtual DbSet<JudicialOfficialBarStatusDim> JudicialOfficialBarStatusDims { get; set; }

    public virtual DbSet<JudicialOfficialBarStatusDimcodeView> JudicialOfficialBarStatusDimcodeViews { get; set; }

    public virtual DbSet<JudicialOfficialCategoryDim> JudicialOfficialCategoryDims { get; set; }

    public virtual DbSet<JudicialOfficialCategoryDimcodeView> JudicialOfficialCategoryDimcodeViews { get; set; }

    public virtual DbSet<JudicialOfficialGuidView> JudicialOfficialGuidViews { get; set; }

    public virtual DbSet<JudicialOfficialPanelDim> JudicialOfficialPanelDims { get; set; }

    public virtual DbSet<JudicialOfficialPanelDimcodeView> JudicialOfficialPanelDimcodeViews { get; set; }

    public virtual DbSet<JudicialOfficialView> JudicialOfficialViews { get; set; }

    public virtual DbSet<Juror> Jurors { get; set; }

    public virtual DbSet<JurorDismissedReasonDim> JurorDismissedReasonDims { get; set; }

    public virtual DbSet<JurorDismissedReasonDimcodeView> JurorDismissedReasonDimcodeViews { get; set; }

    public virtual DbSet<JurorGuidView> JurorGuidViews { get; set; }

    public virtual DbSet<JurorView> JurorViews { get; set; }

    public virtual DbSet<LanguageDim> LanguageDims { get; set; }

    public virtual DbSet<LanguageDimcodeView> LanguageDimcodeViews { get; set; }

    public virtual DbSet<LicenseCategoryDim> LicenseCategoryDims { get; set; }

    public virtual DbSet<LicensePlate> LicensePlates { get; set; }

    public virtual DbSet<LicensePlateCameraDim> LicensePlateCameraDims { get; set; }

    public virtual DbSet<LicensePlateCameraDimcodeView> LicensePlateCameraDimcodeViews { get; set; }

    public virtual DbSet<LicensePlateDirectionDim> LicensePlateDirectionDims { get; set; }

    public virtual DbSet<LicensePlateDirectionDimcodeView> LicensePlateDirectionDimcodeViews { get; set; }

    public virtual DbSet<LicensePlateGuidView> LicensePlateGuidViews { get; set; }

    public virtual DbSet<LicensePlateLaneDim> LicensePlateLaneDims { get; set; }

    public virtual DbSet<LicensePlateLaneDimcodeView> LicensePlateLaneDimcodeViews { get; set; }

    public virtual DbSet<LicensePlateListSourceDim> LicensePlateListSourceDims { get; set; }

    public virtual DbSet<LicensePlateListSourceDimcodeView> LicensePlateListSourceDimcodeViews { get; set; }

    public virtual DbSet<LicensePlateListTypeDim> LicensePlateListTypeDims { get; set; }

    public virtual DbSet<LicensePlateListTypeDimcodeView> LicensePlateListTypeDimcodeViews { get; set; }

    public virtual DbSet<LicensePlateLocation> LicensePlateLocations { get; set; }

    public virtual DbSet<LicensePlateView> LicensePlateViews { get; set; }

    public virtual DbSet<LicensePlateViolationTypeDim> LicensePlateViolationTypeDims { get; set; }

    public virtual DbSet<LicensePlateViolationTypeDimcodeView> LicensePlateViolationTypeDimcodeViews { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<LoadedReport> LoadedReports { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LocationArea> LocationAreas { get; set; }

    public virtual DbSet<LocationAreaContainerGuidView> LocationAreaContainerGuidViews { get; set; }

    public virtual DbSet<LocationAreaContainerView> LocationAreaContainerViews { get; set; }

    public virtual DbSet<LocationAreaGuidView> LocationAreaGuidViews { get; set; }

    public virtual DbSet<LocationAreaView> LocationAreaViews { get; set; }

    public virtual DbSet<LocationCategoryDim> LocationCategoryDims { get; set; }

    public virtual DbSet<LocationCategoryDimcodeView> LocationCategoryDimcodeViews { get; set; }

    public virtual DbSet<LocationComment> LocationComments { get; set; }

    public virtual DbSet<LocationCommentContainerGuidView> LocationCommentContainerGuidViews { get; set; }

    public virtual DbSet<LocationCommentContainerView> LocationCommentContainerViews { get; set; }

    public virtual DbSet<LocationCommentGuidView> LocationCommentGuidViews { get; set; }

    public virtual DbSet<LocationCommentView> LocationCommentViews { get; set; }

    public virtual DbSet<LocationContact> LocationContacts { get; set; }

    public virtual DbSet<LocationContactContainerGuidView> LocationContactContainerGuidViews { get; set; }

    public virtual DbSet<LocationContactContainerView> LocationContactContainerViews { get; set; }

    public virtual DbSet<LocationContactGuidView> LocationContactGuidViews { get; set; }

    public virtual DbSet<LocationContactView> LocationContactViews { get; set; }

    public virtual DbSet<LocationDatumDim> LocationDatumDims { get; set; }

    public virtual DbSet<LocationDatumDimcodeView> LocationDatumDimcodeViews { get; set; }

    public virtual DbSet<LocationDocument> LocationDocuments { get; set; }

    public virtual DbSet<LocationDocumentContainerGuidView> LocationDocumentContainerGuidViews { get; set; }

    public virtual DbSet<LocationDocumentContainerView> LocationDocumentContainerViews { get; set; }

    public virtual DbSet<LocationDocumentGuidView> LocationDocumentGuidViews { get; set; }

    public virtual DbSet<LocationDocumentView> LocationDocumentViews { get; set; }

    public virtual DbSet<LocationImage> LocationImages { get; set; }

    public virtual DbSet<LocationImageContainerGuidView> LocationImageContainerGuidViews { get; set; }

    public virtual DbSet<LocationImageContainerView> LocationImageContainerViews { get; set; }

    public virtual DbSet<LocationImageGuidView> LocationImageGuidViews { get; set; }

    public virtual DbSet<LocationImageView> LocationImageViews { get; set; }

    public virtual DbSet<LocationInvolvementDim> LocationInvolvementDims { get; set; }

    public virtual DbSet<LocationInvolvementDimcodeView> LocationInvolvementDimcodeViews { get; set; }

    public virtual DbSet<LocationMatrix> LocationMatrices { get; set; }

    public virtual DbSet<LocationQuestionnaireContainerGuidView> LocationQuestionnaireContainerGuidViews { get; set; }

    public virtual DbSet<LocationQuestionnaireGuidView> LocationQuestionnaireGuidViews { get; set; }

    public virtual DbSet<LocationQuestionnaireView> LocationQuestionnaireViews { get; set; }

    public virtual DbSet<LocationStreetCategoryDim> LocationStreetCategoryDims { get; set; }

    public virtual DbSet<LocationStreetCategoryDimcodeView> LocationStreetCategoryDimcodeViews { get; set; }

    public virtual DbSet<LocationStreetDirectionDim> LocationStreetDirectionDims { get; set; }

    public virtual DbSet<LocationStreetDirectionDimcodeView> LocationStreetDirectionDimcodeViews { get; set; }

    public virtual DbSet<LogedInPatrol> LogedInPatrols { get; set; }

    public virtual DbSet<LoggedInPatrolPersonView> LoggedInPatrolPersonViews { get; set; }

    public virtual DbSet<LogoutToken> LogoutTokens { get; set; }

    public virtual DbSet<LookUpTranslate> LookUpTranslates { get; set; }

    public virtual DbSet<Lookup> Lookups { get; set; }

    public virtual DbSet<LookupDetail> LookupDetails { get; set; }

    public virtual DbSet<MdtGetAttendedPatrolByArea> MdtGetAttendedPatrolByAreas { get; set; }

    public virtual DbSet<MdtGetEscortingReportBasicDetail> MdtGetEscortingReportBasicDetails { get; set; }

    public virtual DbSet<MdtGetRspImage> MdtGetRspImages { get; set; }

    public virtual DbSet<MdtGetRspProcedure> MdtGetRspProcedures { get; set; }

    public virtual DbSet<MdtGetRspReportBasicDetail> MdtGetRspReportBasicDetails { get; set; }

    public virtual DbSet<MdtGetRspVehicleDatum> MdtGetRspVehicleData { get; set; }

    public virtual DbSet<MdtGetTunnelReportBasicDetail> MdtGetTunnelReportBasicDetails { get; set; }

    public virtual DbSet<MdtViewCheckUserLogin> MdtViewCheckUserLogins { get; set; }

    public virtual DbSet<MdtViewReportDamagedProperty> MdtViewReportDamagedProperties { get; set; }

    public virtual DbSet<MdtViewReportImage> MdtViewReportImages { get; set; }

    public virtual DbSet<MdtViewReportReconstructionPlan> MdtViewReportReconstructionPlans { get; set; }

    public virtual DbSet<MdtViewReportWittness> MdtViewReportWittnesses { get; set; }

    public virtual DbSet<MdtViewVehicleDatum> MdtViewVehicleData { get; set; }

    public virtual DbSet<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; }

    public virtual DbSet<MdtaccidentReportBasicDetail> MdtaccidentReportBasicDetails { get; set; }

    public virtual DbSet<MdtpersonSyncHelper> MdtpersonSyncHelpers { get; set; }

    public virtual DbSet<MdtuserLogDetailsView> MdtuserLogDetailsViews { get; set; }

    public virtual DbSet<MdtuserLogViewForAdmin> MdtuserLogViewForAdmins { get; set; }

    public virtual DbSet<MeasureUnitDim> MeasureUnitDims { get; set; }

    public virtual DbSet<MeasureUnitDimcodeView> MeasureUnitDimcodeViews { get; set; }

    public virtual DbSet<Membership> Memberships { get; set; }

    public virtual DbSet<MilitaryBranchDim> MilitaryBranchDims { get; set; }

    public virtual DbSet<MilitaryBranchDimcodeView> MilitaryBranchDimcodeViews { get; set; }

    public virtual DbSet<MilitaryDischargeTypeDim> MilitaryDischargeTypeDims { get; set; }

    public virtual DbSet<MilitaryDischargeTypeDimcodeView> MilitaryDischargeTypeDimcodeViews { get; set; }

    public virtual DbSet<MilitaryServiceTypeDim> MilitaryServiceTypeDims { get; set; }

    public virtual DbSet<MilitaryServiceTypeDimcodeView> MilitaryServiceTypeDimcodeViews { get; set; }

    public virtual DbSet<MilitaryStatusDim> MilitaryStatusDims { get; set; }

    public virtual DbSet<MilitaryStatusDimcodeView> MilitaryStatusDimcodeViews { get; set; }

    public virtual DbSet<MissingPerson> MissingPeople { get; set; }

    public virtual DbSet<MissingPersonCategoryDim> MissingPersonCategoryDims { get; set; }

    public virtual DbSet<MissingPersonCategoryDimcodeView> MissingPersonCategoryDimcodeViews { get; set; }

    public virtual DbSet<MissingPersonCircumstanceDim> MissingPersonCircumstanceDims { get; set; }

    public virtual DbSet<MissingPersonCircumstanceDimcodeView> MissingPersonCircumstanceDimcodeViews { get; set; }

    public virtual DbSet<MissingPersonGuidView> MissingPersonGuidViews { get; set; }

    public virtual DbSet<MissingPersonStatusDim> MissingPersonStatusDims { get; set; }

    public virtual DbSet<MissingPersonStatusDimcodeView> MissingPersonStatusDimcodeViews { get; set; }

    public virtual DbSet<MissingPersonView> MissingPersonViews { get; set; }

    public virtual DbSet<MissingReport> MissingReports { get; set; }

    public virtual DbSet<MissionCategoryDim> MissionCategoryDims { get; set; }

    public virtual DbSet<MissionPatrolStepDim> MissionPatrolStepDims { get; set; }

    public virtual DbSet<MissionStepDim> MissionStepDims { get; set; }

    public virtual DbSet<MobileClaim> MobileClaims { get; set; }

    public virtual DbSet<MobileCountry> MobileCountries { get; set; }

    public virtual DbSet<MobileForgetPasswordRequest> MobileForgetPasswordRequests { get; set; }

    public virtual DbSet<MobileIncidentTypeDim> MobileIncidentTypeDims { get; set; }

    public virtual DbSet<MobileLicensesPlateListSourceDim> MobileLicensesPlateListSourceDims { get; set; }

    public virtual DbSet<MobileMessage> MobileMessages { get; set; }

    public virtual DbSet<MobileNotification> MobileNotifications { get; set; }

    public virtual DbSet<MobilePlateColorDim> MobilePlateColorDims { get; set; }

    public virtual DbSet<MobilePlateSourceDim> MobilePlateSourceDims { get; set; }

    public virtual DbSet<MobileRegistrationUserRequest> MobileRegistrationUserRequests { get; set; }

    public virtual DbSet<MobileRequest> MobileRequests { get; set; }

    public virtual DbSet<MobileRequestChannelDim> MobileRequestChannelDims { get; set; }

    public virtual DbSet<MobileRequestComment> MobileRequestComments { get; set; }

    public virtual DbSet<MobileRequestImage> MobileRequestImages { get; set; }

    public virtual DbSet<MobileRequestListPlanningStatusDisplay> MobileRequestListPlanningStatusDisplays { get; set; }

    public virtual DbSet<MobileRequestRejectionReasonDim> MobileRequestRejectionReasonDims { get; set; }

    public virtual DbSet<MobileRequestReportPlanningStatusDim> MobileRequestReportPlanningStatusDims { get; set; }

    public virtual DbSet<MobileRequestReportPlanningStatusLog> MobileRequestReportPlanningStatusLogs { get; set; }

    public virtual DbSet<MobileRequestStatusDim> MobileRequestStatusDims { get; set; }

    public virtual DbSet<MobileRequestSurveryAnswersDim> MobileRequestSurveryAnswersDims { get; set; }

    public virtual DbSet<MobileRequestSurvey> MobileRequestSurveys { get; set; }

    public virtual DbSet<MobileRequestSurveyQuestion> MobileRequestSurveyQuestions { get; set; }

    public virtual DbSet<MobileRequestTransaction> MobileRequestTransactions { get; set; }

    public virtual DbSet<MobileRequestTransactionStatusDim> MobileRequestTransactionStatusDims { get; set; }

    public virtual DbSet<MobileRequestVehicle> MobileRequestVehicles { get; set; }

    public virtual DbSet<MobileStatusMessagesDim> MobileStatusMessagesDims { get; set; }

    public virtual DbSet<MobileSurveyLookupDim> MobileSurveyLookupDims { get; set; }

    public virtual DbSet<MobileUser> MobileUsers { get; set; }

    public virtual DbSet<MobileUserLoggingLog> MobileUserLoggingLogs { get; set; }

    public virtual DbSet<MobileVerificationService> MobileVerificationServices { get; set; }

    public virtual DbSet<ModifiedReport> ModifiedReports { get; set; }

    public virtual DbSet<ModifiedVehicle> ModifiedVehicles { get; set; }

    public virtual DbSet<MonthlyTrafficStatisticsView> MonthlyTrafficStatisticsViews { get; set; }

    public virtual DbSet<MotoriGetVehicleInquery> MotoriGetVehicleInqueries { get; set; }

    public virtual DbSet<MotoriServiceLastRun> MotoriServiceLastRuns { get; set; }

    public virtual DbSet<MultiSourceOffenderDim> MultiSourceOffenderDims { get; set; }

    public virtual DbSet<MultiSourceOffenderDimcodeView> MultiSourceOffenderDimcodeViews { get; set; }


    public virtual DbSet<NationalityDim> NationalityDims { get; set; }

    public virtual DbSet<NationalityLanguageDim> NationalityLanguageDims { get; set; }

    public virtual DbSet<NationalityLanguageView> NationalityLanguageViews { get; set; }

    public virtual DbSet<NewGetFullReportDetailsForMotoriIntegrationExtra> NewGetFullReportDetailsForMotoriIntegrationExtras { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationMessageLog> NotificationMessageLogs { get; set; }

    public virtual DbSet<NotificationMessageLogDetail> NotificationMessageLogDetails { get; set; }

    public virtual DbSet<NotificationMessageLogremender> NotificationMessageLogremenders { get; set; }

    public virtual DbSet<NotificationMessageTemplate> NotificationMessageTemplates { get; set; }

    public virtual DbSet<NotificationTypeRole> NotificationTypeRoles { get; set; }

    public virtual DbSet<NotificationWay> NotificationWays { get; set; }

    public virtual DbSet<Objection> Objections { get; set; }

    public virtual DbSet<ObjectionCommentLog> ObjectionCommentLogs { get; set; }

    public virtual DbSet<ObjectionCustomerAdditionalDatum> ObjectionCustomerAdditionalData { get; set; }

    public virtual DbSet<ObjectionCustomerDocument> ObjectionCustomerDocuments { get; set; }

    public virtual DbSet<ObjectionCustomerDocumentTypeDim> ObjectionCustomerDocumentTypeDims { get; set; }

    public virtual DbSet<ObjectionDocument> ObjectionDocuments { get; set; }

    public virtual DbSet<ObjectionExemptionRequestType> ObjectionExemptionRequestTypes { get; set; }

    public virtual DbSet<ObjectionFrontEndRequest> ObjectionFrontEndRequests { get; set; }

    public virtual DbSet<ObjectionLocation> ObjectionLocations { get; set; }

    public virtual DbSet<ObjectionLog> ObjectionLogs { get; set; }

    public virtual DbSet<ObjectionRenewLog> ObjectionRenewLogs { get; set; }

    public virtual DbSet<ObjectionRequestChannelDim> ObjectionRequestChannelDims { get; set; }

    public virtual DbSet<ObjectionRequestModification> ObjectionRequestModifications { get; set; }

    public virtual DbSet<ObjectionRequestType> ObjectionRequestTypes { get; set; }

    public virtual DbSet<ObjectionResultDim> ObjectionResultDims { get; set; }

    public virtual DbSet<ObjectionReturnView> ObjectionReturnViews { get; set; }

    public virtual DbSet<ObjectionSourceOfRequest> ObjectionSourceOfRequests { get; set; }

    public virtual DbSet<ObjectionStatusDim> ObjectionStatusDims { get; set; }

    public virtual DbSet<Offense> Offenses { get; set; }

    public virtual DbSet<OffenseChargeAssociation> OffenseChargeAssociations { get; set; }

    public virtual DbSet<OffenseChargeAssociationContainerGuidView> OffenseChargeAssociationContainerGuidViews { get; set; }

    public virtual DbSet<OffenseChargeAssociationContainerView> OffenseChargeAssociationContainerViews { get; set; }

    public virtual DbSet<OffenseChargeAssociationGuidView> OffenseChargeAssociationGuidViews { get; set; }

    public virtual DbSet<OffenseChargeAssociationView> OffenseChargeAssociationViews { get; set; }

    public virtual DbSet<OffenseCitationAssociation> OffenseCitationAssociations { get; set; }

    public virtual DbSet<OffenseCitationAssociationContainerGuidView> OffenseCitationAssociationContainerGuidViews { get; set; }

    public virtual DbSet<OffenseCitationAssociationContainerView> OffenseCitationAssociationContainerViews { get; set; }

    public virtual DbSet<OffenseCodeDim> OffenseCodeDims { get; set; }

    public virtual DbSet<OffenseCodeDimcodeView> OffenseCodeDimcodeViews { get; set; }

    public virtual DbSet<OffenseComment> OffenseComments { get; set; }

    public virtual DbSet<OffenseCommentContainerGuidView> OffenseCommentContainerGuidViews { get; set; }

    public virtual DbSet<OffenseCommentContainerView> OffenseCommentContainerViews { get; set; }

    public virtual DbSet<OffenseCommentGuidView> OffenseCommentGuidViews { get; set; }

    public virtual DbSet<OffenseCommentView> OffenseCommentViews { get; set; }

    public virtual DbSet<OffenseDrivingIncidentContainerGuidView> OffenseDrivingIncidentContainerGuidViews { get; set; }

    public virtual DbSet<OffenseGuidView> OffenseGuidViews { get; set; }

    public virtual DbSet<OffenseIdentityTheftIncidentContainerGuidView> OffenseIdentityTheftIncidentContainerGuidViews { get; set; }

    public virtual DbSet<OffenseIncidentAssociation> OffenseIncidentAssociations { get; set; }

    public virtual DbSet<OffenseIncidentAssociationContainerGuidView> OffenseIncidentAssociationContainerGuidViews { get; set; }

    public virtual DbSet<OffenseIncidentAssociationContainerView> OffenseIncidentAssociationContainerViews { get; set; }

    public virtual DbSet<OffenseView> OffenseViews { get; set; }

    public virtual DbSet<OfficerActivityDim> OfficerActivityDims { get; set; }

    public virtual DbSet<OfficerActivityDimcodeView> OfficerActivityDimcodeViews { get; set; }

    public virtual DbSet<OfficerAssignmentDim> OfficerAssignmentDims { get; set; }

    public virtual DbSet<OfficerAssignmentDimcodeView> OfficerAssignmentDimcodeViews { get; set; }

    public virtual DbSet<OfficerInjury> OfficerInjuries { get; set; }

    public virtual DbSet<OfficerInjuryGuidView> OfficerInjuryGuidViews { get; set; }

    public virtual DbSet<OfficerInjuryListDim> OfficerInjuryListDims { get; set; }

    public virtual DbSet<OfficerInjuryListDimcodeView> OfficerInjuryListDimcodeViews { get; set; }

    public virtual DbSet<OfficerInjuryView> OfficerInjuryViews { get; set; }

    public virtual DbSet<OfficerMeansOfAttackDim> OfficerMeansOfAttackDims { get; set; }

    public virtual DbSet<OfficerMeansOfAttackDimcodeView> OfficerMeansOfAttackDimcodeViews { get; set; }

    public virtual DbSet<OfflineDto> OfflineDtos { get; set; }

    public virtual DbSet<OfflineIncident> OfflineIncidents { get; set; }

    public virtual DbSet<OfflineOperation> OfflineOperations { get; set; }

    public virtual DbSet<OfflineReportDto> OfflineReportDtos { get; set; }

    public virtual DbSet<OldReportMigration> OldReportMigrations { get; set; }

    public virtual DbSet<OpenIncidentPerAreasView> OpenIncidentPerAreasViews { get; set; }

    public virtual DbSet<OpenIncidentPerPriorityView> OpenIncidentPerPriorityViews { get; set; }

    public virtual DbSet<OpenIncidentPerTypeView> OpenIncidentPerTypeViews { get; set; }

    public virtual DbSet<OperationTypeDim> OperationTypeDims { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<OrganizationAgencyContainerGuidView> OrganizationAgencyContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationAgencyGuidView> OrganizationAgencyGuidViews { get; set; }

    public virtual DbSet<OrganizationAgencyView> OrganizationAgencyViews { get; set; }

    public virtual DbSet<OrganizationAircraftContainerGuidView> OrganizationAircraftContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationAircraftGuidView> OrganizationAircraftGuidViews { get; set; }

    public virtual DbSet<OrganizationAircraftView> OrganizationAircraftViews { get; set; }

    public virtual DbSet<OrganizationArea> OrganizationAreas { get; set; }

    public virtual DbSet<OrganizationArticleContainerGuidView> OrganizationArticleContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationArticleGuidView> OrganizationArticleGuidViews { get; set; }

    public virtual DbSet<OrganizationArticleView> OrganizationArticleViews { get; set; }

    public virtual DbSet<OrganizationAssociation> OrganizationAssociations { get; set; }

    public virtual DbSet<OrganizationAssociationCategoryDim> OrganizationAssociationCategoryDims { get; set; }

    public virtual DbSet<OrganizationAssociationCategoryDimcodeView> OrganizationAssociationCategoryDimcodeViews { get; set; }

    public virtual DbSet<OrganizationAssociationGuidView> OrganizationAssociationGuidViews { get; set; }

    public virtual DbSet<OrganizationAssociationView> OrganizationAssociationViews { get; set; }

    public virtual DbSet<OrganizationCategoryDim> OrganizationCategoryDims { get; set; }

    public virtual DbSet<OrganizationCategoryDimcodeView> OrganizationCategoryDimcodeViews { get; set; }

    public virtual DbSet<OrganizationComment> OrganizationComments { get; set; }

    public virtual DbSet<OrganizationCommentContainerGuidView> OrganizationCommentContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationCommentContainerView> OrganizationCommentContainerViews { get; set; }

    public virtual DbSet<OrganizationCommentGuidView> OrganizationCommentGuidViews { get; set; }

    public virtual DbSet<OrganizationCommentView> OrganizationCommentViews { get; set; }

    public virtual DbSet<OrganizationContact> OrganizationContacts { get; set; }

    public virtual DbSet<OrganizationContactContainerGuidView> OrganizationContactContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationContactContainerView> OrganizationContactContainerViews { get; set; }

    public virtual DbSet<OrganizationContactGuidView> OrganizationContactGuidViews { get; set; }

    public virtual DbSet<OrganizationContactView> OrganizationContactViews { get; set; }

    public virtual DbSet<OrganizationCourtContainerGuidView> OrganizationCourtContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationCourtGuidView> OrganizationCourtGuidViews { get; set; }

    public virtual DbSet<OrganizationCourtView> OrganizationCourtViews { get; set; }

    public virtual DbSet<OrganizationDocument> OrganizationDocuments { get; set; }

    public virtual DbSet<OrganizationDocumentContainerGuidView> OrganizationDocumentContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationDocumentContainerView> OrganizationDocumentContainerViews { get; set; }

    public virtual DbSet<OrganizationDocumentGuidView> OrganizationDocumentGuidViews { get; set; }

    public virtual DbSet<OrganizationDocumentView> OrganizationDocumentViews { get; set; }

    public virtual DbSet<OrganizationDrugContainerGuidView> OrganizationDrugContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationDrugGuidView> OrganizationDrugGuidViews { get; set; }

    public virtual DbSet<OrganizationDrugView> OrganizationDrugViews { get; set; }

    public virtual DbSet<OrganizationEnforcementOfficialContainerGuidView> OrganizationEnforcementOfficialContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationEnforcementOfficialGuidView> OrganizationEnforcementOfficialGuidViews { get; set; }

    public virtual DbSet<OrganizationEnforcementOfficialView> OrganizationEnforcementOfficialViews { get; set; }

    public virtual DbSet<OrganizationEvidenceContainerGuidView> OrganizationEvidenceContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationEvidenceGuidView> OrganizationEvidenceGuidViews { get; set; }

    public virtual DbSet<OrganizationEvidenceView> OrganizationEvidenceViews { get; set; }

    public virtual DbSet<OrganizationFacilityContainerGuidView> OrganizationFacilityContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationFacilityGuidView> OrganizationFacilityGuidViews { get; set; }

    public virtual DbSet<OrganizationFacilityView> OrganizationFacilityViews { get; set; }

    public virtual DbSet<OrganizationFirearmContainerGuidView> OrganizationFirearmContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationFirearmGuidView> OrganizationFirearmGuidViews { get; set; }

    public virtual DbSet<OrganizationFirearmView> OrganizationFirearmViews { get; set; }

    public virtual DbSet<OrganizationGuidView> OrganizationGuidViews { get; set; }

    public virtual DbSet<OrganizationImage> OrganizationImages { get; set; }

    public virtual DbSet<OrganizationImageContainerGuidView> OrganizationImageContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationImageContainerView> OrganizationImageContainerViews { get; set; }

    public virtual DbSet<OrganizationImageGuidView> OrganizationImageGuidViews { get; set; }

    public virtual DbSet<OrganizationImageView> OrganizationImageViews { get; set; }

    public virtual DbSet<OrganizationInvolvementDim> OrganizationInvolvementDims { get; set; }

    public virtual DbSet<OrganizationInvolvementDimcodeView> OrganizationInvolvementDimcodeViews { get; set; }

    public virtual DbSet<OrganizationItem> OrganizationItems { get; set; }

    public virtual DbSet<OrganizationItemContainerGuidView> OrganizationItemContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationItemContainerView> OrganizationItemContainerViews { get; set; }

    public virtual DbSet<OrganizationItemGuidView> OrganizationItemGuidViews { get; set; }

    public virtual DbSet<OrganizationItemStatusDim> OrganizationItemStatusDims { get; set; }

    public virtual DbSet<OrganizationItemView> OrganizationItemViews { get; set; }

    public virtual DbSet<OrganizationJewelryContainerGuidView> OrganizationJewelryContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationJewelryGuidView> OrganizationJewelryGuidViews { get; set; }

    public virtual DbSet<OrganizationJewelryView> OrganizationJewelryViews { get; set; }

    public virtual DbSet<OrganizationJudicialOfficialContainerGuidView> OrganizationJudicialOfficialContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationJudicialOfficialGuidView> OrganizationJudicialOfficialGuidViews { get; set; }

    public virtual DbSet<OrganizationJudicialOfficialView> OrganizationJudicialOfficialViews { get; set; }

    public virtual DbSet<OrganizationJurorContainerGuidView> OrganizationJurorContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationJurorGuidView> OrganizationJurorGuidViews { get; set; }

    public virtual DbSet<OrganizationJurorView> OrganizationJurorViews { get; set; }

    public virtual DbSet<OrganizationLicensePlateContainerGuidView> OrganizationLicensePlateContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationLicensePlateGuidView> OrganizationLicensePlateGuidViews { get; set; }

    public virtual DbSet<OrganizationLicensePlateView> OrganizationLicensePlateViews { get; set; }

    public virtual DbSet<OrganizationLocation> OrganizationLocations { get; set; }

    public virtual DbSet<OrganizationLocationContainerGuidView> OrganizationLocationContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationLocationContainerView> OrganizationLocationContainerViews { get; set; }

    public virtual DbSet<OrganizationLogCategoryDim> OrganizationLogCategoryDims { get; set; }

    public virtual DbSet<OrganizationLogCategoryDimcodeView> OrganizationLogCategoryDimcodeViews { get; set; }

    public virtual DbSet<OrganizationMissingPersonContainerGuidView> OrganizationMissingPersonContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationMissingPersonGuidView> OrganizationMissingPersonGuidViews { get; set; }

    public virtual DbSet<OrganizationMissingPersonView> OrganizationMissingPersonViews { get; set; }

    public virtual DbSet<OrganizationPerson> OrganizationPeople { get; set; }

    public virtual DbSet<OrganizationPersonContainerGuidView> OrganizationPersonContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationPersonContainerView> OrganizationPersonContainerViews { get; set; }

    public virtual DbSet<OrganizationPersonGuidView> OrganizationPersonGuidViews { get; set; }

    public virtual DbSet<OrganizationPersonView> OrganizationPersonViews { get; set; }

    public virtual DbSet<OrganizationPersonnelCategoryDim> OrganizationPersonnelCategoryDims { get; set; }

    public virtual DbSet<OrganizationPersonnelCategoryDimcodeView> OrganizationPersonnelCategoryDimcodeViews { get; set; }

    public virtual DbSet<OrganizationPersonnelRoleDim> OrganizationPersonnelRoleDims { get; set; }

    public virtual DbSet<OrganizationPersonnelRoleDimcodeView> OrganizationPersonnelRoleDimcodeViews { get; set; }

    public virtual DbSet<OrganizationProviderContainerGuidView> OrganizationProviderContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationProviderGuidView> OrganizationProviderGuidViews { get; set; }

    public virtual DbSet<OrganizationProviderView> OrganizationProviderViews { get; set; }

    public virtual DbSet<OrganizationQuestionnaireContainerGuidView> OrganizationQuestionnaireContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationQuestionnaireGuidView> OrganizationQuestionnaireGuidViews { get; set; }

    public virtual DbSet<OrganizationQuestionnaireView> OrganizationQuestionnaireViews { get; set; }

    public virtual DbSet<OrganizationRealestateContainerGuidView> OrganizationRealestateContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationRealestateGuidView> OrganizationRealestateGuidViews { get; set; }

    public virtual DbSet<OrganizationRealestateView> OrganizationRealestateViews { get; set; }

    public virtual DbSet<OrganizationReason> OrganizationReasons { get; set; }

    public virtual DbSet<OrganizationRole> OrganizationRoles { get; set; }

    public virtual DbSet<OrganizationSocialMediaContainerGuidView> OrganizationSocialMediaContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationSocialMediaContainerView> OrganizationSocialMediaContainerViews { get; set; }

    public virtual DbSet<OrganizationSocialMediaGuidView> OrganizationSocialMediaGuidViews { get; set; }

    public virtual DbSet<OrganizationSocialMediaView> OrganizationSocialMediaViews { get; set; }

    public virtual DbSet<OrganizationSocialMedium> OrganizationSocialMedia { get; set; }

    public virtual DbSet<OrganizationStatusDim> OrganizationStatusDims { get; set; }

    public virtual DbSet<OrganizationStatusDimcodeView> OrganizationStatusDimcodeViews { get; set; }

    public virtual DbSet<OrganizationSubjectContainerGuidView> OrganizationSubjectContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationSubjectGuidView> OrganizationSubjectGuidViews { get; set; }

    public virtual DbSet<OrganizationSubjectOrganizationContainerGuidView> OrganizationSubjectOrganizationContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationSubjectOrganizationGuidView> OrganizationSubjectOrganizationGuidViews { get; set; }

    public virtual DbSet<OrganizationSubjectOrganizationView> OrganizationSubjectOrganizationViews { get; set; }

    public virtual DbSet<OrganizationSubjectView> OrganizationSubjectViews { get; set; }

    public virtual DbSet<OrganizationUnit> OrganizationUnits { get; set; }

    public virtual DbSet<OrganizationUnitCategoryDim> OrganizationUnitCategoryDims { get; set; }

    public virtual DbSet<OrganizationUnitCategoryDimcodeView> OrganizationUnitCategoryDimcodeViews { get; set; }

    public virtual DbSet<OrganizationUnitGuidView> OrganizationUnitGuidViews { get; set; }

    public virtual DbSet<OrganizationUnitLog> OrganizationUnitLogs { get; set; }

    public virtual DbSet<OrganizationUnitLogGuidView> OrganizationUnitLogGuidViews { get; set; }

    public virtual DbSet<OrganizationUnitLogView> OrganizationUnitLogViews { get; set; }

    public virtual DbSet<OrganizationUnitPersonnel> OrganizationUnitPersonnel { get; set; }

    public virtual DbSet<OrganizationUnitPersonnelGuidView> OrganizationUnitPersonnelGuidViews { get; set; }

    public virtual DbSet<OrganizationUnitPersonnelView> OrganizationUnitPersonnelViews { get; set; }

    public virtual DbSet<OrganizationUnitStatusDim> OrganizationUnitStatusDims { get; set; }

    public virtual DbSet<OrganizationUnitStatusDimcodeView> OrganizationUnitStatusDimcodeViews { get; set; }

    public virtual DbSet<OrganizationUnitView> OrganizationUnitViews { get; set; }

    public virtual DbSet<OrganizationUserContainerGuidView> OrganizationUserContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationUserGuidView> OrganizationUserGuidViews { get; set; }

    public virtual DbSet<OrganizationUserView> OrganizationUserViews { get; set; }

    public virtual DbSet<OrganizationVehicleContainerGuidView> OrganizationVehicleContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationVehicleGuidView> OrganizationVehicleGuidViews { get; set; }

    public virtual DbSet<OrganizationVehicleView> OrganizationVehicleViews { get; set; }

    public virtual DbSet<OrganizationVesselContainerGuidView> OrganizationVesselContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationVesselGuidView> OrganizationVesselGuidViews { get; set; }

    public virtual DbSet<OrganizationVesselView> OrganizationVesselViews { get; set; }

    public virtual DbSet<OrganizationVictimContainerGuidView> OrganizationVictimContainerGuidViews { get; set; }

    public virtual DbSet<OrganizationVictimGuidView> OrganizationVictimGuidViews { get; set; }

    public virtual DbSet<OrganizationVictimView> OrganizationVictimViews { get; set; }

    public virtual DbSet<OrganizationView> OrganizationViews { get; set; }

    public virtual DbSet<OwnerDatum> OwnerData { get; set; }

    public virtual DbSet<PageAction> PageActions { get; set; }

    public virtual DbSet<PageActionCategoryDim> PageActionCategoryDims { get; set; }

    public virtual DbSet<PageActionRole> PageActionRoles { get; set; }

    public virtual DbSet<PageRole> PageRoles { get; set; }

    public virtual DbSet<Parameter> Parameters { get; set; }

    public virtual DbSet<Parole> Paroles { get; set; }

    public virtual DbSet<PassagePointTypeDim> PassagePointTypeDims { get; set; }

    public virtual DbSet<PassagePointTypeDimcodeView> PassagePointTypeDimcodeViews { get; set; }

    public virtual DbSet<PasswordDictionary> PasswordDictionaries { get; set; }

    public virtual DbSet<PasswordEntryTypeDim> PasswordEntryTypeDims { get; set; }

    public virtual DbSet<PasswordPolicyApplication> PasswordPolicyApplications { get; set; }

    public virtual DbSet<PasswordPolicyConfiguration> PasswordPolicyConfigurations { get; set; }

    public virtual DbSet<PatrolDetailView> PatrolDetailViews { get; set; }

    public virtual DbSet<PatrolLocationNotification> PatrolLocationNotifications { get; set; }

    public virtual DbSet<PatrolLogInView> PatrolLogInViews { get; set; }

    public virtual DbSet<PatrolStatusView> PatrolStatusViews { get; set; }

    public virtual DbSet<PatrolToken> PatrolTokens { get; set; }

    public virtual DbSet<PaymentAccountOperation> PaymentAccountOperations { get; set; }

    public virtual DbSet<PaymentBankAccount> PaymentBankAccounts { get; set; }

    public virtual DbSet<PaymentChannelReturnPage> PaymentChannelReturnPages { get; set; }

    public virtual DbSet<PaymentIntegrationLog> PaymentIntegrationLogs { get; set; }

    public virtual DbSet<PaymentIntegrationMethod> PaymentIntegrationMethods { get; set; }

    public virtual DbSet<PaymentNotification> PaymentNotifications { get; set; }

    public virtual DbSet<PaymentOrganizationInfo> PaymentOrganizationInfos { get; set; }

    public virtual DbSet<PaymentRefundDetail> PaymentRefundDetails { get; set; }

    public virtual DbSet<PaymentRequestStatusDim> PaymentRequestStatusDims { get; set; }

    public virtual DbSet<PaymentRequestTypeDim> PaymentRequestTypeDims { get; set; }

    public virtual DbSet<PaymentSettlement> PaymentSettlements { get; set; }

    public virtual DbSet<PaymentSettlementTransaction> PaymentSettlementTransactions { get; set; }

    public virtual DbSet<PaymentTransaction> PaymentTransactions { get; set; }

    public virtual DbSet<PaymentUserAccount> PaymentUserAccounts { get; set; }

    public virtual DbSet<PendingArmyNotification> PendingArmyNotifications { get; set; }

    public virtual DbSet<PendingPublicNotification> PendingPublicNotifications { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<PersonAffiliation> PersonAffiliations { get; set; }

    public virtual DbSet<PersonAffiliationGuidView> PersonAffiliationGuidViews { get; set; }

    public virtual DbSet<PersonAffiliationView> PersonAffiliationViews { get; set; }

    public virtual DbSet<PersonAircraftContainerGuidView> PersonAircraftContainerGuidViews { get; set; }

    public virtual DbSet<PersonAircraftGuidView> PersonAircraftGuidViews { get; set; }

    public virtual DbSet<PersonAircraftView> PersonAircraftViews { get; set; }

    public virtual DbSet<PersonAlias> PersonAliases { get; set; }

    public virtual DbSet<PersonAliasGuidView> PersonAliasGuidViews { get; set; }

    public virtual DbSet<PersonAliasView> PersonAliasViews { get; set; }

    public virtual DbSet<PersonArea> PersonAreas { get; set; }

    public virtual DbSet<PersonArticleContainerGuidView> PersonArticleContainerGuidViews { get; set; }

    public virtual DbSet<PersonArticleGuidView> PersonArticleGuidViews { get; set; }

    public virtual DbSet<PersonArticleView> PersonArticleViews { get; set; }

    public virtual DbSet<PersonAspnetUser> PersonAspnetUsers { get; set; }

    public virtual DbSet<PersonBloodTypeDim> PersonBloodTypeDims { get; set; }

    public virtual DbSet<PersonBloodTypeDimcodeView> PersonBloodTypeDimcodeViews { get; set; }

    public virtual DbSet<PersonBodyPartStatusDim> PersonBodyPartStatusDims { get; set; }

    public virtual DbSet<PersonBodyPartStatusDimcodeView> PersonBodyPartStatusDimcodeViews { get; set; }

    public virtual DbSet<PersonBodyXrayDim> PersonBodyXrayDims { get; set; }

    public virtual DbSet<PersonBodyXrayDimcodeView> PersonBodyXrayDimcodeViews { get; set; }

    public virtual DbSet<PersonBuildDim> PersonBuildDims { get; set; }

    public virtual DbSet<PersonBuildDimcodeView> PersonBuildDimcodeViews { get; set; }

    public virtual DbSet<PersonCategoryDim> PersonCategoryDims { get; set; }

    public virtual DbSet<PersonCategoryDimcodeView> PersonCategoryDimcodeViews { get; set; }

    public virtual DbSet<PersonCauseofDeathDim> PersonCauseofDeathDims { get; set; }

    public virtual DbSet<PersonCauseofDeathDimcodeView> PersonCauseofDeathDimcodeViews { get; set; }

    public virtual DbSet<PersonCircumcisionDim> PersonCircumcisionDims { get; set; }

    public virtual DbSet<PersonCircumcisionDimcodeView> PersonCircumcisionDimcodeViews { get; set; }

    public virtual DbSet<PersonCitizenship> PersonCitizenships { get; set; }

    public virtual DbSet<PersonCitizenshipGuidView> PersonCitizenshipGuidViews { get; set; }

    public virtual DbSet<PersonCitizenshipView> PersonCitizenshipViews { get; set; }

    public virtual DbSet<PersonClothing> PersonClothings { get; set; }

    public virtual DbSet<PersonClothingCategoryDim> PersonClothingCategoryDims { get; set; }

    public virtual DbSet<PersonClothingCategoryDimcodeView> PersonClothingCategoryDimcodeViews { get; set; }

    public virtual DbSet<PersonClothingColorDim> PersonClothingColorDims { get; set; }

    public virtual DbSet<PersonClothingColorDimcodeView> PersonClothingColorDimcodeViews { get; set; }

    public virtual DbSet<PersonClothingGuidView> PersonClothingGuidViews { get; set; }

    public virtual DbSet<PersonClothingStyleDim> PersonClothingStyleDims { get; set; }

    public virtual DbSet<PersonClothingStyleDimcodeView> PersonClothingStyleDimcodeViews { get; set; }

    public virtual DbSet<PersonClothingView> PersonClothingViews { get; set; }

    public virtual DbSet<PersonComment> PersonComments { get; set; }

    public virtual DbSet<PersonCommentContainerGuidView> PersonCommentContainerGuidViews { get; set; }

    public virtual DbSet<PersonCommentContainerView> PersonCommentContainerViews { get; set; }

    public virtual DbSet<PersonCommentGuidView> PersonCommentGuidViews { get; set; }

    public virtual DbSet<PersonCommentNew01> PersonCommentNew01s { get; set; }

    public virtual DbSet<PersonCommentView> PersonCommentViews { get; set; }

    public virtual DbSet<PersonComplexionDim> PersonComplexionDims { get; set; }

    public virtual DbSet<PersonComplexionDimcodeView> PersonComplexionDimcodeViews { get; set; }

    public virtual DbSet<PersonContact> PersonContacts { get; set; }

    public virtual DbSet<PersonContactContainerGuidView> PersonContactContainerGuidViews { get; set; }

    public virtual DbSet<PersonContactContainerView> PersonContactContainerViews { get; set; }

    public virtual DbSet<PersonContactGuidView> PersonContactGuidViews { get; set; }

    public virtual DbSet<PersonContactView> PersonContactViews { get; set; }

    public virtual DbSet<PersonDisguiseDim> PersonDisguiseDims { get; set; }

    public virtual DbSet<PersonDisguiseDimcodeView> PersonDisguiseDimcodeViews { get; set; }

    public virtual DbSet<PersonDocument> PersonDocuments { get; set; }

    public virtual DbSet<PersonDocumentContainerGuidView> PersonDocumentContainerGuidViews { get; set; }

    public virtual DbSet<PersonDocumentContainerView> PersonDocumentContainerViews { get; set; }

    public virtual DbSet<PersonDocumentGuidView> PersonDocumentGuidViews { get; set; }

    public virtual DbSet<PersonDocumentView> PersonDocumentViews { get; set; }

    public virtual DbSet<PersonDriverLicense> PersonDriverLicenses { get; set; }

    public virtual DbSet<PersonDriverLicenseGuidView> PersonDriverLicenseGuidViews { get; set; }

    public virtual DbSet<PersonDriverLicenseView> PersonDriverLicenseViews { get; set; }

    public virtual DbSet<PersonDrivingInsCoverageCategoryDim> PersonDrivingInsCoverageCategoryDims { get; set; }

    public virtual DbSet<PersonDrivingInsCoverageCategoryDimcodeView> PersonDrivingInsCoverageCategoryDimcodeViews { get; set; }

    public virtual DbSet<PersonDrivingInsuranceStatusDim> PersonDrivingInsuranceStatusDims { get; set; }

    public virtual DbSet<PersonDrivingInsuranceStatusDimcodeView> PersonDrivingInsuranceStatusDimcodeViews { get; set; }

    public virtual DbSet<PersonDrugContainerGuidView> PersonDrugContainerGuidViews { get; set; }

    public virtual DbSet<PersonDrugGuidView> PersonDrugGuidViews { get; set; }

    public virtual DbSet<PersonDrugView> PersonDrugViews { get; set; }

    public virtual DbSet<PersonEducation> PersonEducations { get; set; }

    public virtual DbSet<PersonEducationGuidView> PersonEducationGuidViews { get; set; }

    public virtual DbSet<PersonEducationView> PersonEducationViews { get; set; }

    public virtual DbSet<PersonEmployment> PersonEmployments { get; set; }

    public virtual DbSet<PersonEmploymentGuidView> PersonEmploymentGuidViews { get; set; }

    public virtual DbSet<PersonEmploymentView> PersonEmploymentViews { get; set; }

    public virtual DbSet<PersonEvidenceContainerGuidView> PersonEvidenceContainerGuidViews { get; set; }

    public virtual DbSet<PersonEvidenceGuidView> PersonEvidenceGuidViews { get; set; }

    public virtual DbSet<PersonEvidenceView> PersonEvidenceViews { get; set; }

    public virtual DbSet<PersonEyeColorDim> PersonEyeColorDims { get; set; }

    public virtual DbSet<PersonEyeColorDimcodeView> PersonEyeColorDimcodeViews { get; set; }

    public virtual DbSet<PersonEyeWearDim> PersonEyeWearDims { get; set; }

    public virtual DbSet<PersonEyeWearDimcodeView> PersonEyeWearDimcodeViews { get; set; }

    public virtual DbSet<PersonFacialHairDim> PersonFacialHairDims { get; set; }

    public virtual DbSet<PersonFacialHairDimcodeView> PersonFacialHairDimcodeViews { get; set; }

    public virtual DbSet<PersonFingerprintSet> PersonFingerprintSets { get; set; }

    public virtual DbSet<PersonFingerprintSetGuidView> PersonFingerprintSetGuidViews { get; set; }

    public virtual DbSet<PersonFingerprintSetView> PersonFingerprintSetViews { get; set; }

    public virtual DbSet<PersonFirearmContainerGuidView> PersonFirearmContainerGuidViews { get; set; }

    public virtual DbSet<PersonFirearmGuidView> PersonFirearmGuidViews { get; set; }

    public virtual DbSet<PersonFirearmView> PersonFirearmViews { get; set; }

    public virtual DbSet<PersonGeneralAppearanceDim> PersonGeneralAppearanceDims { get; set; }

    public virtual DbSet<PersonGeneralAppearanceDimcodeView> PersonGeneralAppearanceDimcodeViews { get; set; }

    public virtual DbSet<PersonGuidView> PersonGuidViews { get; set; }

    public virtual DbSet<PersonHairAppearanceDim> PersonHairAppearanceDims { get; set; }

    public virtual DbSet<PersonHairAppearanceDimcodeView> PersonHairAppearanceDimcodeViews { get; set; }

    public virtual DbSet<PersonHairColorDim> PersonHairColorDims { get; set; }

    public virtual DbSet<PersonHairColorDimcodeView> PersonHairColorDimcodeViews { get; set; }

    public virtual DbSet<PersonHairStyleDim> PersonHairStyleDims { get; set; }

    public virtual DbSet<PersonHairStyleDimcodeView> PersonHairStyleDimcodeViews { get; set; }

    public virtual DbSet<PersonHandednessDim> PersonHandednessDims { get; set; }

    public virtual DbSet<PersonHandednessDimcodeView> PersonHandednessDimcodeViews { get; set; }

    public virtual DbSet<PersonHistoricalLocation> PersonHistoricalLocations { get; set; }

    public virtual DbSet<PersonHistoricalTokenShared> PersonHistoricalTokenShareds { get; set; }

    public virtual DbSet<PersonImage> PersonImages { get; set; }

    public virtual DbSet<PersonImageContainerGuidView> PersonImageContainerGuidViews { get; set; }

    public virtual DbSet<PersonImageContainerView> PersonImageContainerViews { get; set; }

    public virtual DbSet<PersonImageGuidView> PersonImageGuidViews { get; set; }

    public virtual DbSet<PersonImageView> PersonImageViews { get; set; }

    public virtual DbSet<PersonInjury> PersonInjuries { get; set; }

    public virtual DbSet<PersonInjuryGuidView> PersonInjuryGuidViews { get; set; }

    public virtual DbSet<PersonInjuryLevelDim> PersonInjuryLevelDims { get; set; }

    public virtual DbSet<PersonInjuryLevelDimcodeView> PersonInjuryLevelDimcodeViews { get; set; }

    public virtual DbSet<PersonInjuryListDim> PersonInjuryListDims { get; set; }

    public virtual DbSet<PersonInjuryListDimcodeView> PersonInjuryListDimcodeViews { get; set; }

    public virtual DbSet<PersonInjuryView> PersonInjuryViews { get; set; }

    public virtual DbSet<PersonIntoxication> PersonIntoxications { get; set; }

    public virtual DbSet<PersonIntoxicationGuidView> PersonIntoxicationGuidViews { get; set; }

    public virtual DbSet<PersonIntoxicationView> PersonIntoxicationViews { get; set; }

    public virtual DbSet<PersonInvolvementDim> PersonInvolvementDims { get; set; }

    public virtual DbSet<PersonInvolvementDimcodeView> PersonInvolvementDimcodeViews { get; set; }

    public virtual DbSet<PersonItem> PersonItems { get; set; }

    public virtual DbSet<PersonItemContainerGuidView> PersonItemContainerGuidViews { get; set; }

    public virtual DbSet<PersonItemContainerView> PersonItemContainerViews { get; set; }

    public virtual DbSet<PersonItemGuidView> PersonItemGuidViews { get; set; }

    public virtual DbSet<PersonItemView> PersonItemViews { get; set; }

    public virtual DbSet<PersonJewelryContainerGuidView> PersonJewelryContainerGuidViews { get; set; }

    public virtual DbSet<PersonJewelryDim> PersonJewelryDims { get; set; }

    public virtual DbSet<PersonJewelryDimcodeView> PersonJewelryDimcodeViews { get; set; }

    public virtual DbSet<PersonJewelryGuidView> PersonJewelryGuidViews { get; set; }

    public virtual DbSet<PersonJewelryView> PersonJewelryViews { get; set; }

    public virtual DbSet<PersonLanguage> PersonLanguages { get; set; }

    public virtual DbSet<PersonLanguageGuidView> PersonLanguageGuidViews { get; set; }

    public virtual DbSet<PersonLanguageView> PersonLanguageViews { get; set; }

    public virtual DbSet<PersonLicensePlateContainerGuidView> PersonLicensePlateContainerGuidViews { get; set; }

    public virtual DbSet<PersonLicensePlateGuidView> PersonLicensePlateGuidViews { get; set; }

    public virtual DbSet<PersonLicensePlateView> PersonLicensePlateViews { get; set; }

    public virtual DbSet<PersonLocation> PersonLocations { get; set; }

    public virtual DbSet<PersonLocationContainerGuidView> PersonLocationContainerGuidViews { get; set; }

    public virtual DbSet<PersonLocationContainerView> PersonLocationContainerViews { get; set; }

    public virtual DbSet<PersonMaritalStatusDim> PersonMaritalStatusDims { get; set; }

    public virtual DbSet<PersonMaritalStatusDimcodeView> PersonMaritalStatusDimcodeViews { get; set; }

    public virtual DbSet<PersonMedicalByDim> PersonMedicalByDims { get; set; }

    public virtual DbSet<PersonMedicalByDimcodeView> PersonMedicalByDimcodeViews { get; set; }

    public virtual DbSet<PersonMedicalCautionDim> PersonMedicalCautionDims { get; set; }

    public virtual DbSet<PersonMedicalCautionDimcodeView> PersonMedicalCautionDimcodeViews { get; set; }

    public virtual DbSet<PersonMedicalCondition> PersonMedicalConditions { get; set; }

    public virtual DbSet<PersonMedicalConditionGuidView> PersonMedicalConditionGuidViews { get; set; }

    public virtual DbSet<PersonMedicalConditionTypeDim> PersonMedicalConditionTypeDims { get; set; }

    public virtual DbSet<PersonMedicalConditionTypeDimcodeView> PersonMedicalConditionTypeDimcodeViews { get; set; }

    public virtual DbSet<PersonMedicalConditionView> PersonMedicalConditionViews { get; set; }

    public virtual DbSet<PersonMedicationDim> PersonMedicationDims { get; set; }

    public virtual DbSet<PersonMedicationDimcodeView> PersonMedicationDimcodeViews { get; set; }

    public virtual DbSet<PersonMilitarySummary> PersonMilitarySummaries { get; set; }

    public virtual DbSet<PersonMilitarySummaryGuidView> PersonMilitarySummaryGuidViews { get; set; }

    public virtual DbSet<PersonMilitarySummaryView> PersonMilitarySummaryViews { get; set; }

    public virtual DbSet<PersonMoruaryDim> PersonMoruaryDims { get; set; }

    public virtual DbSet<PersonMoruaryDimcodeView> PersonMoruaryDimcodeViews { get; set; }

    public virtual DbSet<PersonNameCategoryDim> PersonNameCategoryDims { get; set; }

    public virtual DbSet<PersonNameCategoryDimcodeView> PersonNameCategoryDimcodeViews { get; set; }

    public virtual DbSet<PersonNationality> PersonNationalities { get; set; }

    public virtual DbSet<PersonOtherIdentification> PersonOtherIdentifications { get; set; }

    public virtual DbSet<PersonOtherIdentificationGuidView> PersonOtherIdentificationGuidViews { get; set; }

    public virtual DbSet<PersonOtherIdentificationView> PersonOtherIdentificationViews { get; set; }

    public virtual DbSet<PersonPhysicalDetail> PersonPhysicalDetails { get; set; }

    public virtual DbSet<PersonPhysicalDetailGuidView> PersonPhysicalDetailGuidViews { get; set; }

    public virtual DbSet<PersonPhysicalDetailView> PersonPhysicalDetailViews { get; set; }

    public virtual DbSet<PersonPhysicalFeature> PersonPhysicalFeatures { get; set; }

    public virtual DbSet<PersonPhysicalFeatureGuidView> PersonPhysicalFeatureGuidViews { get; set; }

    public virtual DbSet<PersonPhysicalFeatureView> PersonPhysicalFeatureViews { get; set; }

    public virtual DbSet<PersonPhysicianDim> PersonPhysicianDims { get; set; }

    public virtual DbSet<PersonPhysicianDimcodeView> PersonPhysicianDimcodeViews { get; set; }

    public virtual DbSet<PersonQuestionnaireContainerGuidView> PersonQuestionnaireContainerGuidViews { get; set; }

    public virtual DbSet<PersonQuestionnaireGuidView> PersonQuestionnaireGuidViews { get; set; }

    public virtual DbSet<PersonQuestionnaireView> PersonQuestionnaireViews { get; set; }

    public virtual DbSet<PersonRaceDim> PersonRaceDims { get; set; }

    public virtual DbSet<PersonRaceDimcodeView> PersonRaceDimcodeViews { get; set; }

    public virtual DbSet<PersonRealestateContainerGuidView> PersonRealestateContainerGuidViews { get; set; }

    public virtual DbSet<PersonRealestateGuidView> PersonRealestateGuidViews { get; set; }

    public virtual DbSet<PersonRealestateView> PersonRealestateViews { get; set; }

    public virtual DbSet<PersonRelationship> PersonRelationships { get; set; }

    public virtual DbSet<PersonRelationshipGuidView> PersonRelationshipGuidViews { get; set; }

    public virtual DbSet<PersonRelationshipTypeDim> PersonRelationshipTypeDims { get; set; }

    public virtual DbSet<PersonRelationshipTypeDimcodeView> PersonRelationshipTypeDimcodeViews { get; set; }

    public virtual DbSet<PersonRelationshipView> PersonRelationshipViews { get; set; }

    public virtual DbSet<PersonReligionDim> PersonReligionDims { get; set; }

    public virtual DbSet<PersonReligionDimcodeView> PersonReligionDimcodeViews { get; set; }

    public virtual DbSet<PersonReportsAssignment> PersonReportsAssignments { get; set; }

    public virtual DbSet<PersonSexDim> PersonSexDims { get; set; }

    public virtual DbSet<PersonSexDimcodeView> PersonSexDimcodeViews { get; set; }

    public virtual DbSet<PersonSexualOrientationDim> PersonSexualOrientationDims { get; set; }

    public virtual DbSet<PersonSexualOrientationDimcodeView> PersonSexualOrientationDimcodeViews { get; set; }

    public virtual DbSet<PersonSkinToneDim> PersonSkinToneDims { get; set; }

    public virtual DbSet<PersonSkinToneDimcodeView> PersonSkinToneDimcodeViews { get; set; }

    public virtual DbSet<PersonSocialMediaContainerGuidView> PersonSocialMediaContainerGuidViews { get; set; }

    public virtual DbSet<PersonSocialMediaContainerView> PersonSocialMediaContainerViews { get; set; }

    public virtual DbSet<PersonSocialMediaGuidView> PersonSocialMediaGuidViews { get; set; }

    public virtual DbSet<PersonSocialMediaView> PersonSocialMediaViews { get; set; }

    public virtual DbSet<PersonSocialMedium> PersonSocialMedia { get; set; }

    public virtual DbSet<PersonSpeechDim> PersonSpeechDims { get; set; }

    public virtual DbSet<PersonSpeechDimcodeView> PersonSpeechDimcodeViews { get; set; }

    public virtual DbSet<PersonStatusDim> PersonStatusDims { get; set; }

    public virtual DbSet<PersonStatusDimcodeView> PersonStatusDimcodeViews { get; set; }

    public virtual DbSet<PersonTooth> PersonTeeth { get; set; }

    public virtual DbSet<PersonToothGuidView> PersonToothGuidViews { get; set; }

    public virtual DbSet<PersonToothView> PersonToothViews { get; set; }

    public virtual DbSet<PersonTransportedByDim> PersonTransportedByDims { get; set; }

    public virtual DbSet<PersonTransportedByDimcodeView> PersonTransportedByDimcodeViews { get; set; }

    public virtual DbSet<PersonVehicleContainerGuidView> PersonVehicleContainerGuidViews { get; set; }

    public virtual DbSet<PersonVehicleGuidView> PersonVehicleGuidViews { get; set; }

    public virtual DbSet<PersonVehicleView> PersonVehicleViews { get; set; }

    public virtual DbSet<PersonVesselContainerGuidView> PersonVesselContainerGuidViews { get; set; }

    public virtual DbSet<PersonVesselGuidView> PersonVesselGuidViews { get; set; }

    public virtual DbSet<PersonVesselView> PersonVesselViews { get; set; }

    public virtual DbSet<PersonView> PersonViews { get; set; }

    public virtual DbSet<PersonVitalStatistic> PersonVitalStatistics { get; set; }

    public virtual DbSet<PersonVitalStatisticGuidView> PersonVitalStatisticGuidViews { get; set; }

    public virtual DbSet<PersonVitalStatisticView> PersonVitalStatisticViews { get; set; }

    public virtual DbSet<PhysicalAppearanceHistory> PhysicalAppearanceHistories { get; set; }

    public virtual DbSet<PhysicalAppearanceHistoryGuidView> PhysicalAppearanceHistoryGuidViews { get; set; }

    public virtual DbSet<PhysicalAppearanceHistoryView> PhysicalAppearanceHistoryViews { get; set; }

    public virtual DbSet<PhysicalFeatureCategoryDim> PhysicalFeatureCategoryDims { get; set; }

    public virtual DbSet<PhysicalFeatureCategoryDimcodeView> PhysicalFeatureCategoryDimcodeViews { get; set; }

    public virtual DbSet<PhysicalFeatureHandicapDim> PhysicalFeatureHandicapDims { get; set; }

    public virtual DbSet<PhysicalFeatureHandicapDimcodeView> PhysicalFeatureHandicapDimcodeViews { get; set; }

    public virtual DbSet<PhysicalFeatureLocationDim> PhysicalFeatureLocationDims { get; set; }

    public virtual DbSet<PhysicalFeatureLocationDimcodeView> PhysicalFeatureLocationDimcodeViews { get; set; }

    public virtual DbSet<PhysicalFeatureSeverityDim> PhysicalFeatureSeverityDims { get; set; }

    public virtual DbSet<PhysicalFeatureSeverityDimcodeView> PhysicalFeatureSeverityDimcodeViews { get; set; }

    public virtual DbSet<PioneerDatum> PioneerData { get; set; }

    public virtual DbSet<PioneerIntegrationLog> PioneerIntegrationLogs { get; set; }

    public virtual DbSet<Plate> Plates { get; set; }

    public virtual DbSet<PlateClassToPlateColorMap> PlateClassToPlateColorMaps { get; set; }

    public virtual DbSet<PlateMatrix> PlateMatrices { get; set; }

    public virtual DbSet<PlateSourceDim> PlateSourceDims { get; set; }

    public virtual DbSet<PlateSourceDim1> PlateSourceDim1s { get; set; }

    public virtual DbSet<PlateSourceToPlateTypeMap> PlateSourceToPlateTypeMaps { get; set; }

    public virtual DbSet<PlateTypeToPlateClassMap> PlateTypeToPlateClassMaps { get; set; }

    public virtual DbSet<PoliceIncident> PoliceIncidents { get; set; }

    public virtual DbSet<PolicyDim> PolicyDims { get; set; }

    public virtual DbSet<PolicyDimcodeView> PolicyDimcodeViews { get; set; }

    public virtual DbSet<PrivateReportCode> PrivateReportCodes { get; set; }

    public virtual DbSet<Probation> Probations { get; set; }

    public virtual DbSet<ProceduresDim> ProceduresDims { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<ProgramDim> ProgramDims { get; set; }

    public virtual DbSet<ProgramDimcodeView> ProgramDimcodeViews { get; set; }

    public virtual DbSet<ProgramParticipation> ProgramParticipations { get; set; }

    public virtual DbSet<ProgramReferralStatusDim> ProgramReferralStatusDims { get; set; }

    public virtual DbSet<ProgramReferralStatusDimcodeView> ProgramReferralStatusDimcodeViews { get; set; }

    public virtual DbSet<ProgramStatusDim> ProgramStatusDims { get; set; }

    public virtual DbSet<ProgramStatusDimcodeView> ProgramStatusDimcodeViews { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<PropertyTypeDim> PropertyTypeDims { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<ProviderCategoryDim> ProviderCategoryDims { get; set; }

    public virtual DbSet<ProviderCategoryDimcodeView> ProviderCategoryDimcodeViews { get; set; }

    public virtual DbSet<ProviderGuidView> ProviderGuidViews { get; set; }

    public virtual DbSet<ProviderStatusDim> ProviderStatusDims { get; set; }

    public virtual DbSet<ProviderStatusDimcodeView> ProviderStatusDimcodeViews { get; set; }

    public virtual DbSet<ProviderView> ProviderViews { get; set; }

    public virtual DbSet<PublicNotifier> PublicNotifiers { get; set; }

    public virtual DbSet<PurchaseRequest> PurchaseRequests { get; set; }

    public virtual DbSet<PurchaseRequestComment> PurchaseRequestComments { get; set; }

    public virtual DbSet<PurchaseRequestLog> PurchaseRequestLogs { get; set; }

    public virtual DbSet<PurchaseRequestStatus> PurchaseRequestStatuses { get; set; }

    public virtual DbSet<PurchaseRequestViewHelper> PurchaseRequestViewHelpers { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionCategoryDim> QuestionCategoryDims { get; set; }

    public virtual DbSet<QuestionCategoryDimcodeView> QuestionCategoryDimcodeViews { get; set; }

    public virtual DbSet<QuestionChoice> QuestionChoices { get; set; }

    public virtual DbSet<QuestionChoiceGuidView> QuestionChoiceGuidViews { get; set; }

    public virtual DbSet<QuestionChoiceView> QuestionChoiceViews { get; set; }

    public virtual DbSet<QuestionGuidView> QuestionGuidViews { get; set; }

    public virtual DbSet<QuestionView> QuestionViews { get; set; }

    public virtual DbSet<Questionnaire> Questionnaires { get; set; }

    public virtual DbSet<QuestionnaireCategoryDim> QuestionnaireCategoryDims { get; set; }

    public virtual DbSet<QuestionnaireCategoryDimcodeView> QuestionnaireCategoryDimcodeViews { get; set; }

    public virtual DbSet<QuestionnaireGuidView> QuestionnaireGuidViews { get; set; }

    public virtual DbSet<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }

    public virtual DbSet<QuestionnaireQuestionContainerGuidView> QuestionnaireQuestionContainerGuidViews { get; set; }

    public virtual DbSet<QuestionnaireQuestionContainerView> QuestionnaireQuestionContainerViews { get; set; }

    public virtual DbSet<QuestionnaireQuestionGuidView> QuestionnaireQuestionGuidViews { get; set; }

    public virtual DbSet<QuestionnaireQuestionView> QuestionnaireQuestionViews { get; set; }

    public virtual DbSet<QuestionnaireView> QuestionnaireViews { get; set; }

    public virtual DbSet<Realestate> Realestates { get; set; }

    public virtual DbSet<RealestateAttachedFacilityDim> RealestateAttachedFacilityDims { get; set; }

    public virtual DbSet<RealestateAttachedFacilityDimcodeView> RealestateAttachedFacilityDimcodeViews { get; set; }

    public virtual DbSet<RealestateCategoryDim> RealestateCategoryDims { get; set; }

    public virtual DbSet<RealestateCategoryDimcodeView> RealestateCategoryDimcodeViews { get; set; }

    public virtual DbSet<RealestateGuidView> RealestateGuidViews { get; set; }

    public virtual DbSet<RealestateView> RealestateViews { get; set; }

    public virtual DbSet<ReasonCategoryDim> ReasonCategoryDims { get; set; }

    public virtual DbSet<RecalculationReportChengeLog> RecalculationReportChengeLogs { get; set; }

    public virtual DbSet<RecalculationRequest> RecalculationRequests { get; set; }

    public virtual DbSet<RecalculationRequestAttachment> RecalculationRequestAttachments { get; set; }

    public virtual DbSet<RecalculationRequestTypeDim> RecalculationRequestTypeDims { get; set; }

    public virtual DbSet<RecalculationStatusDim> RecalculationStatusDims { get; set; }

    public virtual DbSet<RecentReportForMotori> RecentReportForMotoris { get; set; }

    public virtual DbSet<ReconstructionGraph> ReconstructionGraphs { get; set; }

    public virtual DbSet<ReconstructionMap> ReconstructionMaps { get; set; }

    public virtual DbSet<ReferenceType> ReferenceTypes { get; set; }

    public virtual DbSet<RegisterofAction> RegisterofActions { get; set; }

    public virtual DbSet<RegisterofActionCategoryDim> RegisterofActionCategoryDims { get; set; }

    public virtual DbSet<RegisterofActionCategoryDimcodeView> RegisterofActionCategoryDimcodeViews { get; set; }

    public virtual DbSet<Release> Releases { get; set; }

    public virtual DbSet<ReleaseAuthorizationCategoryDim> ReleaseAuthorizationCategoryDims { get; set; }

    public virtual DbSet<ReleaseAuthorizationCategoryDimcodeView> ReleaseAuthorizationCategoryDimcodeViews { get; set; }

    public virtual DbSet<ReleaseReasonDim> ReleaseReasonDims { get; set; }

    public virtual DbSet<ReleaseReasonDimcodeView> ReleaseReasonDimcodeViews { get; set; }

    public virtual DbSet<RemainingCompanyPatrolsAction> RemainingCompanyPatrolsActions { get; set; }

    public virtual DbSet<RemainingCompanyPatrolsActionType> RemainingCompanyPatrolsActionTypes { get; set; }

    public virtual DbSet<RepairComment> RepairComments { get; set; }

    public virtual DbSet<RepairCompleteLog> RepairCompleteLogs { get; set; }

    public virtual DbSet<RepairGarage> RepairGarages { get; set; }

    public virtual DbSet<RepairGaragePerson> RepairGaragePeople { get; set; }

    public virtual DbSet<RepairImage> RepairImages { get; set; }

    public virtual DbSet<RepairInvoice> RepairInvoices { get; set; }

    public virtual DbSet<RepairLog> RepairLogs { get; set; }

    public virtual DbSet<RepairNotification> RepairNotifications { get; set; }

    public virtual DbSet<RepairNotificationLog> RepairNotificationLogs { get; set; }

    public virtual DbSet<RepairPermissionReportView> RepairPermissionReportViews { get; set; }

    public virtual DbSet<RepairQuote> RepairQuotes { get; set; }

    public virtual DbSet<RepairQuoteItem> RepairQuoteItems { get; set; }

    public virtual DbSet<RepairQuoteItemTypeDim> RepairQuoteItemTypeDims { get; set; }

    public virtual DbSet<RepairRating> RepairRatings { get; set; }

    public virtual DbSet<RepairRequest> RepairRequests { get; set; }

    public virtual DbSet<RepairRequestGarage> RepairRequestGarages { get; set; }

    public virtual DbSet<RepairRequestGarageStatusHistory> RepairRequestGarageStatusHistories { get; set; }

    public virtual DbSet<RepairRequestStatusForSaaedAdminView> RepairRequestStatusForSaaedAdminViews { get; set; }

    public virtual DbSet<RepairRequestStatusHistory> RepairRequestStatusHistories { get; set; }

    public virtual DbSet<RepairRequestStatusPerGarageView> RepairRequestStatusPerGarageViews { get; set; }

    public virtual DbSet<RepairStatusDim> RepairStatusDims { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportAccessChannel> ReportAccessChannels { get; set; }

    public virtual DbSet<ReportAccessLog> ReportAccessLogs { get; set; }

    public virtual DbSet<ReportActionTaken> ReportActionTakens { get; set; }

    public virtual DbSet<ReportAmbulance> ReportAmbulances { get; set; }

    public virtual DbSet<ReportArcReportCount> ReportArcReportCounts { get; set; }

    public virtual DbSet<ReportAreaDim> ReportAreaDims { get; set; }

    public virtual DbSet<ReportAreaView> ReportAreaViews { get; set; }

    public virtual DbSet<ReportChangeStatusLog> ReportChangeStatusLogs { get; set; }

    public virtual DbSet<ReportCode> ReportCodes { get; set; }

    public virtual DbSet<ReportCodeViewHelper> ReportCodeViewHelpers { get; set; }

    public virtual DbSet<ReportDamagedProperty> ReportDamagedProperties { get; set; }

    public virtual DbSet<ReportDetailsForPoliceRequest> ReportDetailsForPoliceRequests { get; set; }

    public virtual DbSet<ReportDetailsForPoliceRequestView> ReportDetailsForPoliceRequestViews { get; set; }

    public virtual DbSet<ReportField> ReportFields { get; set; }

    public virtual DbSet<ReportFieldTypeDim> ReportFieldTypeDims { get; set; }

    public virtual DbSet<ReportFile> ReportFiles { get; set; }

    public virtual DbSet<ReportGroup> ReportGroups { get; set; }

    public virtual DbSet<ReportHeatMap> ReportHeatMaps { get; set; }

    public virtual DbSet<ReportImage> ReportImages { get; set; }

    public virtual DbSet<ReportInquiryLog> ReportInquiryLogs { get; set; }

    public virtual DbSet<ReportMdtAccidentBasicDetail> ReportMdtAccidentBasicDetails { get; set; }

    public virtual DbSet<ReportModifcationLogComment> ReportModifcationLogComments { get; set; }

    public virtual DbSet<ReportModification> ReportModifications { get; set; }

    public virtual DbSet<ReportModificationAssociation> ReportModificationAssociations { get; set; }

    public virtual DbSet<ReportModificationLog> ReportModificationLogs { get; set; }

    public virtual DbSet<ReportModificationLogStatusDim> ReportModificationLogStatusDims { get; set; }

    public virtual DbSet<ReportModificationRelationshipTypeDim> ReportModificationRelationshipTypeDims { get; set; }

    public virtual DbSet<ReportModificationResponsibilityDim> ReportModificationResponsibilityDims { get; set; }

    public virtual DbSet<ReportModificationStatus> ReportModificationStatuses { get; set; }

    public virtual DbSet<ReportModificationType> ReportModificationTypes { get; set; }

    public virtual DbSet<ReportNotifier> ReportNotifiers { get; set; }

    public virtual DbSet<ReportNotifierLog> ReportNotifierLogs { get; set; }

    public virtual DbSet<ReportPaymentTransaction> ReportPaymentTransactions { get; set; }

    public virtual DbSet<ReportPaymentTransactionLog> ReportPaymentTransactionLogs { get; set; }

    public virtual DbSet<ReportReasonDim> ReportReasonDims { get; set; }

    public virtual DbSet<ReportReconstructionPlan> ReportReconstructionPlans { get; set; }

    public virtual DbSet<ReportRequest> ReportRequests { get; set; }

    public virtual DbSet<ReportRequestClientDatum> ReportRequestClientData { get; set; }

    public virtual DbSet<ReportRequestComment> ReportRequestComments { get; set; }

    public virtual DbSet<ReportRequestDocument> ReportRequestDocuments { get; set; }

    public virtual DbSet<ReportRequestTypeDim> ReportRequestTypeDims { get; set; }

    public virtual DbSet<ReportReuploadLog> ReportReuploadLogs { get; set; }

    public virtual DbSet<ReportSerializedDto> ReportSerializedDtos { get; set; }

    public virtual DbSet<ReportShortCodesView> ReportShortCodesViews { get; set; }

    public virtual DbSet<ReportSourceTypeDim> ReportSourceTypeDims { get; set; }

    public virtual DbSet<ReportStatusDim> ReportStatusDims { get; set; }

    public virtual DbSet<ReportStatusToReportTypeMap> ReportStatusToReportTypeMaps { get; set; }

    public virtual DbSet<ReportStatusToReportTypeMapTemp> ReportStatusToReportTypeMapTemps { get; set; }

    public virtual DbSet<ReportTypeDim> ReportTypeDims { get; set; }

    public virtual DbSet<ReportVehicleDataView> ReportVehicleDataViews { get; set; }

    public virtual DbSet<ReportVehicleDatawithCode> ReportVehicleDatawithCodes { get; set; }

    public virtual DbSet<ReportVehicleDatum> ReportVehicleData { get; set; }

    public virtual DbSet<ReportWithPublicDamagedToOpenReport> ReportWithPublicDamagedToOpenReports { get; set; }

    public virtual DbSet<ReportWittness> ReportWittnesses { get; set; }

    public virtual DbSet<ReportsReuploadLog> ReportsReuploadLogs { get; set; }

    public virtual DbSet<ReportsReuploadReasonsDim> ReportsReuploadReasonsDims { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<RequestCategoryDim> RequestCategoryDims { get; set; }

    public virtual DbSet<RequestCategoryDimcodeView> RequestCategoryDimcodeViews { get; set; }

    public virtual DbSet<RequestCheck> RequestChecks { get; set; }

    public virtual DbSet<RequestCheckCategoryDim> RequestCheckCategoryDims { get; set; }

    public virtual DbSet<RequestCheckCategoryDimcodeView> RequestCheckCategoryDimcodeViews { get; set; }

    public virtual DbSet<RequestCheckGuidView> RequestCheckGuidViews { get; set; }

    public virtual DbSet<RequestCheckView> RequestCheckViews { get; set; }

    public virtual DbSet<RequestInputMethodDim> RequestInputMethodDims { get; set; }

    public virtual DbSet<RequestInputMethodDimcodeView> RequestInputMethodDimcodeViews { get; set; }

    public virtual DbSet<RequestOffense> RequestOffenses { get; set; }

    public virtual DbSet<RequestOffenseCategoryDim> RequestOffenseCategoryDims { get; set; }

    public virtual DbSet<RequestOffenseCategoryDimcodeView> RequestOffenseCategoryDimcodeViews { get; set; }

    public virtual DbSet<RequestOffenseGuidView> RequestOffenseGuidViews { get; set; }

    public virtual DbSet<RequestOffenseView> RequestOffenseViews { get; set; }

    public virtual DbSet<RequestService> RequestServices { get; set; }

    public virtual DbSet<RequestServiceCategoryDim> RequestServiceCategoryDims { get; set; }

    public virtual DbSet<RequestServiceCategoryDimcodeView> RequestServiceCategoryDimcodeViews { get; set; }

    public virtual DbSet<RequestServiceGuidView> RequestServiceGuidViews { get; set; }

    public virtual DbSet<RequestServiceTypeDim> RequestServiceTypeDims { get; set; }

    public virtual DbSet<RequestServiceView> RequestServiceViews { get; set; }

    public virtual DbSet<RequestStepDim> RequestStepDims { get; set; }

    public virtual DbSet<RequestViolation> RequestViolations { get; set; }

    public virtual DbSet<RequestViolationCategoryDim> RequestViolationCategoryDims { get; set; }

    public virtual DbSet<RequestViolationCategoryDimcodeView> RequestViolationCategoryDimcodeViews { get; set; }

    public virtual DbSet<RequestViolationGuidView> RequestViolationGuidViews { get; set; }

    public virtual DbSet<RequestViolationView> RequestViolationViews { get; set; }

    public virtual DbSet<ResponseReConstructionPerHour> ResponseReConstructionPerHours { get; set; }

    public virtual DbSet<ResponseReConstructionPerMonth> ResponseReConstructionPerMonths { get; set; }

    public virtual DbSet<ResponseTime> ResponseTimes { get; set; }

    public virtual DbSet<ResponseTimeByAreasView> ResponseTimeByAreasViews { get; set; }

    public virtual DbSet<RetrySm> RetrySms { get; set; }

    public virtual DbSet<ReuploadReportsReasonsDim> ReuploadReportsReasonsDims { get; set; }

    public virtual DbSet<RevampDatum> RevampData { get; set; }

    public virtual DbSet<RiskScoreAxa> RiskScoreAxas { get; set; }

    public virtual DbSet<RoadAssistActivityFlowMapping> RoadAssistActivityFlowMappings { get; set; }

    public virtual DbSet<RoadAssistAppConfig> RoadAssistAppConfigs { get; set; }

    public virtual DbSet<RoadAssistDayPeriod> RoadAssistDayPeriods { get; set; }

    public virtual DbSet<RoadAssistFuelFeesPerUnit> RoadAssistFuelFeesPerUnits { get; set; }

    public virtual DbSet<RoadAssistFuelPackageDim> RoadAssistFuelPackageDims { get; set; }

    public virtual DbSet<RoadAssistFuelTypeDim> RoadAssistFuelTypeDims { get; set; }

    public virtual DbSet<RoadAssistGeneralInfo> RoadAssistGeneralInfos { get; set; }

    public virtual DbSet<RoadAssistIntegrationTokenLog> RoadAssistIntegrationTokenLogs { get; set; }

    public virtual DbSet<RoadAssistNotificationMessageConfig> RoadAssistNotificationMessageConfigs { get; set; }

    public virtual DbSet<RoadAssistOtp> RoadAssistOtps { get; set; }

    public virtual DbSet<RoadAssistPaymentFee> RoadAssistPaymentFees { get; set; }

    public virtual DbSet<RoadAssistProvider> RoadAssistProviders { get; set; }

    public virtual DbSet<RoadAssistProviderBranch> RoadAssistProviderBranches { get; set; }

    public virtual DbSet<RoadAssistProviderPerson> RoadAssistProviderPersons { get; set; }

    public virtual DbSet<RoadAssistProviderService> RoadAssistProviderServices { get; set; }

    public virtual DbSet<RoadAssistProviderVehicle> RoadAssistProviderVehicles { get; set; }

    public virtual DbSet<RoadAssistRatingNotificationLog> RoadAssistRatingNotificationLogs { get; set; }

    public virtual DbSet<RoadAssistRequest> RoadAssistRequests { get; set; }

    public virtual DbSet<RoadAssistRequestActivityDim> RoadAssistRequestActivityDims { get; set; }

    public virtual DbSet<RoadAssistRequestComment> RoadAssistRequestComments { get; set; }

    public virtual DbSet<RoadAssistRequestFee> RoadAssistRequestFees { get; set; }

    public virtual DbSet<RoadAssistRequestFeesTypeDim> RoadAssistRequestFeesTypeDims { get; set; }

    public virtual DbSet<RoadAssistRequestRejectionReasonDim> RoadAssistRequestRejectionReasonDims { get; set; }

    public virtual DbSet<RoadAssistRequestStatusDim> RoadAssistRequestStatusDims { get; set; }

    public virtual DbSet<RoadAssistRequestStatusLog> RoadAssistRequestStatusLogs { get; set; }

    public virtual DbSet<RoadAssistRider> RoadAssistRiders { get; set; }

    public virtual DbSet<RoadAssistSaaedShareValue> RoadAssistSaaedShareValues { get; set; }

    public virtual DbSet<RoadAssistService> RoadAssistServices { get; set; }

    public virtual DbSet<RoadAssistServicePriceByDistance> RoadAssistServicePriceByDistances { get; set; }

    public virtual DbSet<RoadAssistServicePriceByEmirate> RoadAssistServicePriceByEmirates { get; set; }

    public virtual DbSet<RoadAssistServiceStatusDim> RoadAssistServiceStatusDims { get; set; }

    public virtual DbSet<RoadAssistServiceStep> RoadAssistServiceSteps { get; set; }

    public virtual DbSet<RoadAssistStatusFlowMapping> RoadAssistStatusFlowMappings { get; set; }

    public virtual DbSet<RoadAssistTax> RoadAssistTaxes { get; set; }

    public virtual DbSet<RoadAssistTimeFrameDatum> RoadAssistTimeFrameData { get; set; }

    public virtual DbSet<RoadAssistUser> RoadAssistUsers { get; set; }

    public virtual DbSet<RoadAssistUserType> RoadAssistUserTypes { get; set; }

    public virtual DbSet<RoadAssistUserVehicle> RoadAssistUserVehicles { get; set; }

    public virtual DbSet<RoadAssistVehicle> RoadAssistVehicles { get; set; }

    public virtual DbSet<RoadSpeedDim> RoadSpeedDims { get; set; }

    public virtual DbSet<RoadSurfaceDim> RoadSurfaceDims { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RowStatusDim> RowStatusDims { get; set; }

    public virtual DbSet<RowStatusDimcodeView> RowStatusDimcodeViews { get; set; }

    public virtual DbSet<RspDamagedLevelDim> RspDamagedLevelDims { get; set; }

    public virtual DbSet<RspDriverDatum> RspDriverData { get; set; }

    public virtual DbSet<RspProcedure> RspProcedures { get; set; }

    public virtual DbSet<RspReportBasicDetail> RspReportBasicDetails { get; set; }

    public virtual DbSet<RspReportsVehicleDatum> RspReportsVehicleData { get; set; }

    public virtual DbSet<RspVehicleDatum> RspVehicleData { get; set; }

    public virtual DbSet<Saaed360CancelledIncidentCall> Saaed360CancelledIncidentCalls { get; set; }

    public virtual DbSet<Saaed360IncidentCounter> Saaed360IncidentCounters { get; set; }

    public virtual DbSet<Saaed360RequestCounter> Saaed360RequestCounters { get; set; }

    public virtual DbSet<Saaed360VersionInfoDim> Saaed360VersionInfoDims { get; set; }

    public virtual DbSet<Saaed360ViewCancelledIncident> Saaed360ViewCancelledIncidents { get; set; }

    public virtual DbSet<Saaed360ViewCancelledIncidentDetail> Saaed360ViewCancelledIncidentDetails { get; set; }

    public virtual DbSet<Saaed360ViewDispatcherPatrol> Saaed360ViewDispatcherPatrols { get; set; }

    public virtual DbSet<Saaed360ViewIncidentAssignedPatrol> Saaed360ViewIncidentAssignedPatrols { get; set; }

    public virtual DbSet<Saaed360ViewIncidentDelayStatus> Saaed360ViewIncidentDelayStatuses { get; set; }

    public virtual DbSet<Saaed360ViewIncidentDetail> Saaed360ViewIncidentDetails { get; set; }

    public virtual DbSet<Saaed360ViewIncidentList> Saaed360ViewIncidentLists { get; set; }

    public virtual DbSet<Saaed360ViewIncidentSearchDetail> Saaed360ViewIncidentSearchDetails { get; set; }

    public virtual DbSet<Saaed360ViewPatrolAvilabilty> Saaed360ViewPatrolAvilabilties { get; set; }

    public virtual DbSet<SaaedCommunicationPercentageReportView> SaaedCommunicationPercentageReportViews { get; set; }

    public virtual DbSet<SaaedCompromiseDetail> SaaedCompromiseDetails { get; set; }

    public virtual DbSet<SaaedConfigLevel> SaaedConfigLevels { get; set; }

    public virtual DbSet<SaaedConfiscationDatum> SaaedConfiscationData { get; set; }

    public virtual DbSet<SaaedCustomExceptionLog> SaaedCustomExceptionLogs { get; set; }

    public virtual DbSet<SaaedDailyCommunicationPercentageReportView> SaaedDailyCommunicationPercentageReportViews { get; set; }

    public virtual DbSet<SaaedGetReportList> SaaedGetReportLists { get; set; }

    public virtual DbSet<SaaedIdamagePartsIntegrationLog> SaaedIdamagePartsIntegrationLogs { get; set; }

    public virtual DbSet<SaaedIimageTypeDim> SaaedIimageTypeDims { get; set; }

    public virtual DbSet<SaaedIncidentSupportsforMap> SaaedIncidentSupportsforMaps { get; set; }

    public virtual DbSet<SaaedIplateNumbersIntegrationLog> SaaedIplateNumbersIntegrationLogs { get; set; }

    public virtual DbSet<SaaedIprocessedImage> SaaedIprocessedImages { get; set; }

    public virtual DbSet<SaaedLog> SaaedLogs { get; set; }

    public virtual DbSet<SaaedReportControlCenterCheckupTool> SaaedReportControlCenterCheckupTools { get; set; }

    public virtual DbSet<SaaedReportIncidentDetail> SaaedReportIncidentDetails { get; set; }

    public virtual DbSet<SaaedReportOpenDelayedIncidentDetail> SaaedReportOpenDelayedIncidentDetails { get; set; }

    public virtual DbSet<SaaedReportOpenIncidentDetail> SaaedReportOpenIncidentDetails { get; set; }

    public virtual DbSet<SaaedReportTotalDelayedIncidentDetail> SaaedReportTotalDelayedIncidentDetails { get; set; }

    public virtual DbSet<SaaedReportTotalIncidentDetail> SaaedReportTotalIncidentDetails { get; set; }

    public virtual DbSet<SaaedReportTotalNotDelayedIncidentDetail> SaaedReportTotalNotDelayedIncidentDetails { get; set; }

    public virtual DbSet<SaaedReportsTable> SaaedReportsTables { get; set; }

    public virtual DbSet<SaaedSsrsreportsTable> SaaedSsrsreportsTables { get; set; }

    public virtual DbSet<SaaedSsrsreportsType> SaaedSsrsreportsTypes { get; set; }

    public virtual DbSet<SaaedSupervisorMissionForTe> SaaedSupervisorMissionForTes { get; set; }

    public virtual DbSet<SaaedTransferedReport> SaaedTransferedReports { get; set; }

    public virtual DbSet<SaaedheckupToolsReport> SaaedheckupToolsReports { get; set; }

    public virtual DbSet<SaeedLog> SaeedLogs { get; set; }

    public virtual DbSet<SaeedOlapreportsTable> SaeedOlapreportsTables { get; set; }

    public virtual DbSet<SaeedOlapreportsType> SaeedOlapreportsTypes { get; set; }

    public virtual DbSet<ScenarioDim> ScenarioDims { get; set; }

    public virtual DbSet<Schema> Schemas { get; set; }

    public virtual DbSet<Search> Searches { get; set; }

    public virtual DbSet<SearchCategoryDim> SearchCategoryDims { get; set; }

    public virtual DbSet<SearchCategoryDimcodeView> SearchCategoryDimcodeViews { get; set; }

    public virtual DbSet<SearchCompareDim> SearchCompareDims { get; set; }

    public virtual DbSet<SearchCompareDimcodeView> SearchCompareDimcodeViews { get; set; }

    public virtual DbSet<SearchDataTypeDim> SearchDataTypeDims { get; set; }

    public virtual DbSet<SearchDataTypeDimcodeView> SearchDataTypeDimcodeViews { get; set; }

    public virtual DbSet<SearchDetail> SearchDetails { get; set; }

    public virtual DbSet<SearchDetailGuidView> SearchDetailGuidViews { get; set; }

    public virtual DbSet<SearchDetailView> SearchDetailViews { get; set; }

    public virtual DbSet<SearchParameterDim> SearchParameterDims { get; set; }

    public virtual DbSet<SearchParameterDimcodeView> SearchParameterDimcodeViews { get; set; }

    public virtual DbSet<SearchResponse> SearchResponses { get; set; }

    public virtual DbSet<SearchResponseStatusDim> SearchResponseStatusDims { get; set; }

    public virtual DbSet<SearchResponseStatusDimcodeView> SearchResponseStatusDimcodeViews { get; set; }

    public virtual DbSet<SectorDim> SectorDims { get; set; }

    public virtual DbSet<SecurityApiLog> SecurityApiLogs { get; set; }

    public virtual DbSet<SecuritySituation> SecuritySituations { get; set; }

    public virtual DbSet<SecuritySituationAttachement> SecuritySituationAttachements { get; set; }

    public virtual DbSet<SecuritySituationMonitorLevelDim> SecuritySituationMonitorLevelDims { get; set; }

    public virtual DbSet<SecuritySituationSourceDim> SecuritySituationSourceDims { get; set; }

    public virtual DbSet<SecuritySituationStatus> SecuritySituationStatuses { get; set; }

    public virtual DbSet<SecuritySituationStatusDim> SecuritySituationStatusDims { get; set; }

    public virtual DbSet<SecuritySituationTypeDim> SecuritySituationTypeDims { get; set; }

    public virtual DbSet<SellAnyCar> SellAnyCars { get; set; }

    public virtual DbSet<Sentence> Sentences { get; set; }

    public virtual DbSet<SentenceGroupingDim> SentenceGroupingDims { get; set; }

    public virtual DbSet<SentenceGroupingDimcodeView> SentenceGroupingDimcodeViews { get; set; }

    public virtual DbSet<Server> Servers { get; set; }

    public virtual DbSet<ServiceCall> ServiceCalls { get; set; }

    public virtual DbSet<ServiceCallCategoryDim> ServiceCallCategoryDims { get; set; }

    public virtual DbSet<ServiceCallCategoryDimcodeView> ServiceCallCategoryDimcodeViews { get; set; }

    public virtual DbSet<ServiceCallClearanceDim> ServiceCallClearanceDims { get; set; }

    public virtual DbSet<ServiceCallClearanceDimcodeView> ServiceCallClearanceDimcodeViews { get; set; }

    public virtual DbSet<ServiceCallDispositionDim> ServiceCallDispositionDims { get; set; }

    public virtual DbSet<ServiceCallDispositionDimcodeView> ServiceCallDispositionDimcodeViews { get; set; }

    public virtual DbSet<ServiceCallIncidentTypeDim> ServiceCallIncidentTypeDims { get; set; }

    public virtual DbSet<ServiceCallMechanismDim> ServiceCallMechanismDims { get; set; }

    public virtual DbSet<ServiceCallMechanismDimcodeView> ServiceCallMechanismDimcodeViews { get; set; }

    public virtual DbSet<ServiceCallPriorityDim> ServiceCallPriorityDims { get; set; }

    public virtual DbSet<ServiceCallPriorityDimcodeView> ServiceCallPriorityDimcodeViews { get; set; }

    public virtual DbSet<ServiceCallPriorityReasonDim> ServiceCallPriorityReasonDims { get; set; }

    public virtual DbSet<ServiceCallSourceDim> ServiceCallSourceDims { get; set; }

    public virtual DbSet<ServiceCallSourceDimcodeView> ServiceCallSourceDimcodeViews { get; set; }

    public virtual DbSet<ServiceCenterLookup> ServiceCenterLookups { get; set; }

    public virtual DbSet<ServiceClassDim> ServiceClassDims { get; set; }

    public virtual DbSet<ServiceClassDimcodeView> ServiceClassDimcodeViews { get; set; }

    public virtual DbSet<ServiceLogTable> ServiceLogTables { get; set; }

    public virtual DbSet<ServiceRequestResponseLogger> ServiceRequestResponseLoggers { get; set; }

    public virtual DbSet<Set> Sets { get; set; }


    public virtual DbSet<SmartDispatchingAreaConfiguration> SmartDispatchingAreaConfigurations { get; set; }

    public virtual DbSet<SmartDispatchingConfiguration> SmartDispatchingConfigurations { get; set; }

    public virtual DbSet<SmartDispatchingEmirateConfiguration> SmartDispatchingEmirateConfigurations { get; set; }

    public virtual DbSet<SmartDispatchingIncidentStatusDim> SmartDispatchingIncidentStatusDims { get; set; }

    public virtual DbSet<SmartDispatchingIncidentStatusLog> SmartDispatchingIncidentStatusLogs { get; set; }

    public virtual DbSet<SmartDispatchingReturnToOperationRoomLog> SmartDispatchingReturnToOperationRoomLogs { get; set; }

    public virtual DbSet<SmsMessageLog> SmsMessageLogs { get; set; }

    public virtual DbSet<Smslog> Smslogs { get; set; }

    public virtual DbSet<SmstoWhatsDetail> SmstoWhatsDetails { get; set; }

    public virtual DbSet<SmstoWhatsMapping> SmstoWhatsMappings { get; set; }

    public virtual DbSet<SocialMediaAuthorization> SocialMediaAuthorizations { get; set; }

    public virtual DbSet<SocialMediaAuthorizationGuidView> SocialMediaAuthorizationGuidViews { get; set; }

    public virtual DbSet<SocialMediaAuthorizationView> SocialMediaAuthorizationViews { get; set; }

    public virtual DbSet<SocialMediaCategoryDim> SocialMediaCategoryDims { get; set; }

    public virtual DbSet<SocialMediaCategoryDimcodeView> SocialMediaCategoryDimcodeViews { get; set; }

    public virtual DbSet<SocialMediaComment> SocialMediaComments { get; set; }

    public virtual DbSet<SocialMediaCommentContainerGuidView> SocialMediaCommentContainerGuidViews { get; set; }

    public virtual DbSet<SocialMediaCommentContainerView> SocialMediaCommentContainerViews { get; set; }

    public virtual DbSet<SocialMediaCommentGuidView> SocialMediaCommentGuidViews { get; set; }

    public virtual DbSet<SocialMediaCommentView> SocialMediaCommentViews { get; set; }

    public virtual DbSet<SocialMediaEnforcementOfficialContainerGuidView> SocialMediaEnforcementOfficialContainerGuidViews { get; set; }

    public virtual DbSet<SocialMediaEnforcementOfficialGuidView> SocialMediaEnforcementOfficialGuidViews { get; set; }

    public virtual DbSet<SocialMediaEnforcementOfficialView> SocialMediaEnforcementOfficialViews { get; set; }

    public virtual DbSet<SocialMediaGuidView> SocialMediaGuidViews { get; set; }

    public virtual DbSet<SocialMediaInvolvementDim> SocialMediaInvolvementDims { get; set; }

    public virtual DbSet<SocialMediaInvolvementDimcodeView> SocialMediaInvolvementDimcodeViews { get; set; }

    public virtual DbSet<SocialMediaJudicialOfficialContainerGuidView> SocialMediaJudicialOfficialContainerGuidViews { get; set; }

    public virtual DbSet<SocialMediaJudicialOfficialGuidView> SocialMediaJudicialOfficialGuidViews { get; set; }

    public virtual DbSet<SocialMediaJudicialOfficialView> SocialMediaJudicialOfficialViews { get; set; }

    public virtual DbSet<SocialMediaJurorContainerGuidView> SocialMediaJurorContainerGuidViews { get; set; }

    public virtual DbSet<SocialMediaJurorGuidView> SocialMediaJurorGuidViews { get; set; }

    public virtual DbSet<SocialMediaJurorView> SocialMediaJurorViews { get; set; }

    public virtual DbSet<SocialMediaLocation> SocialMediaLocations { get; set; }

    public virtual DbSet<SocialMediaLocationContainerGuidView> SocialMediaLocationContainerGuidViews { get; set; }

    public virtual DbSet<SocialMediaLocationContainerView> SocialMediaLocationContainerViews { get; set; }

    public virtual DbSet<SocialMediaMissingPersonContainerGuidView> SocialMediaMissingPersonContainerGuidViews { get; set; }

    public virtual DbSet<SocialMediaMissingPersonGuidView> SocialMediaMissingPersonGuidViews { get; set; }

    public virtual DbSet<SocialMediaMissingPersonView> SocialMediaMissingPersonViews { get; set; }

    public virtual DbSet<SocialMediaPerson> SocialMediaPeople { get; set; }

    public virtual DbSet<SocialMediaPersonContainerGuidView> SocialMediaPersonContainerGuidViews { get; set; }

    public virtual DbSet<SocialMediaPersonContainerView> SocialMediaPersonContainerViews { get; set; }

    public virtual DbSet<SocialMediaPersonGuidView> SocialMediaPersonGuidViews { get; set; }

    public virtual DbSet<SocialMediaPersonView> SocialMediaPersonViews { get; set; }

    public virtual DbSet<SocialMediaSubjectContainerGuidView> SocialMediaSubjectContainerGuidViews { get; set; }

    public virtual DbSet<SocialMediaSubjectGuidView> SocialMediaSubjectGuidViews { get; set; }

    public virtual DbSet<SocialMediaSubjectView> SocialMediaSubjectViews { get; set; }

    public virtual DbSet<SocialMediaUserContainerGuidView> SocialMediaUserContainerGuidViews { get; set; }

    public virtual DbSet<SocialMediaUserGuidView> SocialMediaUserGuidViews { get; set; }

    public virtual DbSet<SocialMediaUserView> SocialMediaUserViews { get; set; }

    public virtual DbSet<SocialMediaVictimContainerGuidView> SocialMediaVictimContainerGuidViews { get; set; }

    public virtual DbSet<SocialMediaVictimGuidView> SocialMediaVictimGuidViews { get; set; }

    public virtual DbSet<SocialMediaVictimView> SocialMediaVictimViews { get; set; }

    public virtual DbSet<SocialMediaView> SocialMediaViews { get; set; }

    public virtual DbSet<SocialMedium> SocialMedia { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<SourceCategoryDim> SourceCategoryDims { get; set; }

    public virtual DbSet<SourceCategoryDimcodeView> SourceCategoryDimcodeViews { get; set; }

    public virtual DbSet<SourceDetail> SourceDetails { get; set; }

    public virtual DbSet<SourceDirectoryCategoryDim> SourceDirectoryCategoryDims { get; set; }

    public virtual DbSet<SourceDirectoryCategoryDimcodeView> SourceDirectoryCategoryDimcodeViews { get; set; }

    public virtual DbSet<SourceOfModificationDim> SourceOfModificationDims { get; set; }

    public virtual DbSet<SourcePolicyDim> SourcePolicyDims { get; set; }

    public virtual DbSet<SourcePolicyDimcodeView> SourcePolicyDimcodeViews { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<State1> States1 { get; set; }

    public virtual DbSet<StateNotificationRole> StateNotificationRoles { get; set; }

    public virtual DbSet<StateNotificationRoleRelationTypeDim> StateNotificationRoleRelationTypeDims { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<StatusDim> StatusDims { get; set; }

    public virtual DbSet<StatusDimcodeView> StatusDimcodeViews { get; set; }

    public virtual DbSet<StatuteDim> StatuteDims { get; set; }

    public virtual DbSet<StatuteDimcodeView> StatuteDimcodeViews { get; set; }

    public virtual DbSet<StatuteSeverityDim> StatuteSeverityDims { get; set; }

    public virtual DbSet<StatuteSeverityDimcodeView> StatuteSeverityDimcodeViews { get; set; }

    public virtual DbSet<StreetCrossStreet> StreetCrossStreets { get; set; }

    public virtual DbSet<StreetDim> StreetDims { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<SubjectDisciplinaryActionDim> SubjectDisciplinaryActionDims { get; set; }

    public virtual DbSet<SubjectDisciplinaryActionDimcodeView> SubjectDisciplinaryActionDimcodeViews { get; set; }

    public virtual DbSet<SubjectExtraditionDim> SubjectExtraditionDims { get; set; }

    public virtual DbSet<SubjectExtraditionDimcodeView> SubjectExtraditionDimcodeViews { get; set; }

    public virtual DbSet<SubjectGuidView> SubjectGuidViews { get; set; }

    public virtual DbSet<SubjectOrganization> SubjectOrganizations { get; set; }

    public virtual DbSet<SubjectOrganizationGuidView> SubjectOrganizationGuidViews { get; set; }

    public virtual DbSet<SubjectOrganizationView> SubjectOrganizationViews { get; set; }

    public virtual DbSet<SubjectRegistration> SubjectRegistrations { get; set; }

    public virtual DbSet<SubjectRegistrationCategoryDim> SubjectRegistrationCategoryDims { get; set; }

    public virtual DbSet<SubjectRegistrationCategoryDimcodeView> SubjectRegistrationCategoryDimcodeViews { get; set; }

    public virtual DbSet<SubjectRegistrationGuidView> SubjectRegistrationGuidViews { get; set; }

    public virtual DbSet<SubjectRegistrationView> SubjectRegistrationViews { get; set; }

    public virtual DbSet<SubjectStatusDim> SubjectStatusDims { get; set; }

    public virtual DbSet<SubjectStatusDimcodeView> SubjectStatusDimcodeViews { get; set; }

    public virtual DbSet<SubjectView> SubjectViews { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<SubscriptionCategoryDim> SubscriptionCategoryDims { get; set; }

    public virtual DbSet<SubscriptionCategoryDimcodeView> SubscriptionCategoryDimcodeViews { get; set; }

    public virtual DbSet<SubscriptionGuidView> SubscriptionGuidViews { get; set; }

    public virtual DbSet<SubscriptionInvolvementDim> SubscriptionInvolvementDims { get; set; }

    public virtual DbSet<SubscriptionInvolvementDimcodeView> SubscriptionInvolvementDimcodeViews { get; set; }

    public virtual DbSet<SubscriptionLocation> SubscriptionLocations { get; set; }

    public virtual DbSet<SubscriptionLocationContainerGuidView> SubscriptionLocationContainerGuidViews { get; set; }

    public virtual DbSet<SubscriptionLocationContainerView> SubscriptionLocationContainerViews { get; set; }

    public virtual DbSet<SubscriptionPolygon> SubscriptionPolygons { get; set; }

    public virtual DbSet<SubscriptionPolygonCategoryDim> SubscriptionPolygonCategoryDims { get; set; }

    public virtual DbSet<SubscriptionPolygonCategoryDimcodeView> SubscriptionPolygonCategoryDimcodeViews { get; set; }

    public virtual DbSet<SubscriptionPolygonGuidView> SubscriptionPolygonGuidViews { get; set; }

    public virtual DbSet<SubscriptionPolygonView> SubscriptionPolygonViews { get; set; }

    public virtual DbSet<SubscriptionSocialMediaContainerGuidView> SubscriptionSocialMediaContainerGuidViews { get; set; }

    public virtual DbSet<SubscriptionSocialMediaContainerView> SubscriptionSocialMediaContainerViews { get; set; }

    public virtual DbSet<SubscriptionSocialMediaGuidView> SubscriptionSocialMediaGuidViews { get; set; }

    public virtual DbSet<SubscriptionSocialMediaView> SubscriptionSocialMediaViews { get; set; }

    public virtual DbSet<SubscriptionSocialMedium> SubscriptionSocialMedia { get; set; }

    public virtual DbSet<SubscriptionSubdivision> SubscriptionSubdivisions { get; set; }

    public virtual DbSet<SubscriptionSubdivisionGuidView> SubscriptionSubdivisionGuidViews { get; set; }

    public virtual DbSet<SubscriptionSubdivisionView> SubscriptionSubdivisionViews { get; set; }

    public virtual DbSet<SubscriptionView> SubscriptionViews { get; set; }

    public virtual DbSet<Supervision> Supervisions { get; set; }

    public virtual DbSet<SupervisionCategoryDim> SupervisionCategoryDims { get; set; }

    public virtual DbSet<SupervisionCategoryDimcodeView> SupervisionCategoryDimcodeViews { get; set; }

    public virtual DbSet<SupervisionCustodyStatusDim> SupervisionCustodyStatusDims { get; set; }

    public virtual DbSet<SupervisionCustodyStatusDimcodeView> SupervisionCustodyStatusDimcodeViews { get; set; }

    public virtual DbSet<SupervisionStatusDim> SupervisionStatusDims { get; set; }

    public virtual DbSet<SupervisionStatusDimcodeView> SupervisionStatusDimcodeViews { get; set; }

    public virtual DbSet<SupportAuditDim> SupportAuditDims { get; set; }

    public virtual DbSet<SupportExceptionDimtable> SupportExceptionDimtables { get; set; }

    public virtual DbSet<SupportSupportExceptionDimtableDescriptionCodeColumnDetail> SupportSupportExceptionDimtableDescriptionCodeColumnDetails { get; set; }

    public virtual DbSet<SupportTableForExtraAssociationTableColumn> SupportTableForExtraAssociationTableColumns { get; set; }

    public virtual DbSet<SupportTableSpsFunctionsAndView> SupportTableSpsFunctionsAndViews { get; set; }

    public virtual DbSet<SupportTablesAndRelation> SupportTablesAndRelations { get; set; }

    public virtual DbSet<Survey> Surveys { get; set; }

    public virtual DbSet<SurveyAnswer> SurveyAnswers { get; set; }

    public virtual DbSet<SurveyAnswerGroup> SurveyAnswerGroups { get; set; }

    public virtual DbSet<SurveyDetail> SurveyDetails { get; set; }

    public virtual DbSet<SurveyDetailedView> SurveyDetailedViews { get; set; }

    public virtual DbSet<SurveyLanguage> SurveyLanguages { get; set; }

    public virtual DbSet<SurveyLog> SurveyLogs { get; set; }

    public virtual DbSet<SurveyMessageLog> SurveyMessageLogs { get; set; }

    public virtual DbSet<SurveyMessageTrace> SurveyMessageTraces { get; set; }

    public virtual DbSet<SurveyMessege> SurveyMesseges { get; set; }

    public virtual DbSet<SurveyQuestion> SurveyQuestions { get; set; }

    public virtual DbSet<SurveyQuestionType> SurveyQuestionTypes { get; set; }

    public virtual DbSet<SurveySecondaryStatusView> SurveySecondaryStatusViews { get; set; }

    public virtual DbSet<SurveyStatus> SurveyStatuses { get; set; }

    public virtual DbSet<SurveyStatusView> SurveyStatusViews { get; set; }

    public virtual DbSet<SyncOrganizationHelper> SyncOrganizationHelpers { get; set; }

    public virtual DbSet<SysKey> SysKeys { get; set; }

    //public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<TaskCategoryDim> TaskCategoryDims { get; set; }

    public virtual DbSet<TaskInvolvementDim> TaskInvolvementDims { get; set; }

    public virtual DbSet<TaskItem> TaskItems { get; set; }

    public virtual DbSet<TelephonyCall> TelephonyCalls { get; set; }

    public virtual DbSet<TelephonyCallLog> TelephonyCallLogs { get; set; }

    public virtual DbSet<TfaenqueryLog> TfaenqueryLogs { get; set; }

    public virtual DbSet<TheftCategoryDim> TheftCategoryDims { get; set; }

    public virtual DbSet<TheftCategoryDimcodeView> TheftCategoryDimcodeViews { get; set; }

    public virtual DbSet<TicketRequest> TicketRequests { get; set; }

    public virtual DbSet<TicketRequestInfo> TicketRequestInfos { get; set; }

    public virtual DbSet<TimeCategoryDim> TimeCategoryDims { get; set; }

    public virtual DbSet<TimeDim> TimeDims { get; set; }

    public virtual DbSet<TipLead> TipLeads { get; set; }

    public virtual DbSet<TipLeadCategoryDim> TipLeadCategoryDims { get; set; }

    public virtual DbSet<TipLeadCategoryDimcodeView> TipLeadCategoryDimcodeViews { get; set; }

    public virtual DbSet<TipLeadContentValidityDim> TipLeadContentValidityDims { get; set; }

    public virtual DbSet<TipLeadContentValidityDimcodeView> TipLeadContentValidityDimcodeViews { get; set; }

    public virtual DbSet<TipLeadOffense> TipLeadOffenses { get; set; }

    public virtual DbSet<TipLeadOffenseGuidView> TipLeadOffenseGuidViews { get; set; }

    public virtual DbSet<TipLeadOffenseView> TipLeadOffenseViews { get; set; }

    public virtual DbSet<TipLeadReliabilityDim> TipLeadReliabilityDims { get; set; }

    public virtual DbSet<TipLeadReliabilityDimcodeView> TipLeadReliabilityDimcodeViews { get; set; }

    public virtual DbSet<TipLeadSourceCategoryDim> TipLeadSourceCategoryDims { get; set; }

    public virtual DbSet<TipLeadSourceCategoryDimcodeView> TipLeadSourceCategoryDimcodeViews { get; set; }

    public virtual DbSet<TipLeadSourceMethodContactDim> TipLeadSourceMethodContactDims { get; set; }

    public virtual DbSet<TipLeadSourceMethodContactDimcodeView> TipLeadSourceMethodContactDimcodeViews { get; set; }

    public virtual DbSet<TrackingHelpView> TrackingHelpViews { get; set; }

    public virtual DbSet<TrafficCode> TrafficCodes { get; set; }

    public virtual DbSet<TrafficStatusDim> TrafficStatusDims { get; set; }

    public virtual DbSet<TrafficViolation> TrafficViolations { get; set; }

    public virtual DbSet<TrafficViolationRejectionReason> TrafficViolationRejectionReasons { get; set; }

    public virtual DbSet<TrafficViolationStatusDim> TrafficViolationStatusDims { get; set; }

    public virtual DbSet<TrafficViolationStatusLog> TrafficViolationStatusLogs { get; set; }

    public virtual DbSet<TrafficViolationTypeDim> TrafficViolationTypeDims { get; set; }

    public virtual DbSet<TrafficViolationUploadStatusDim> TrafficViolationUploadStatusDims { get; set; }

    public virtual DbSet<TransactionType> TransactionTypes { get; set; }

    public virtual DbSet<TransferStatusDim> TransferStatusDims { get; set; }

    public virtual DbSet<TransferedReportDocument> TransferedReportDocuments { get; set; }

    public virtual DbSet<TransferedReportStatusList> TransferedReportStatusLists { get; set; }

    public virtual DbSet<TranslationReport> TranslationReports { get; set; }

    public virtual DbSet<TranslationTablesType> TranslationTablesTypes { get; set; }

    public virtual DbSet<TrueFalseDim> TrueFalseDims { get; set; }

    public virtual DbSet<TsviewIncidentDetail> TsviewIncidentDetails { get; set; }

    public virtual DbSet<TunnelReportBasicDetail> TunnelReportBasicDetails { get; set; }

    public virtual DbSet<UaepassLog> UaepassLogs { get; set; }

    public virtual DbSet<UnderProcessConvertLog> UnderProcessConvertLogs { get; set; }

    public virtual DbSet<UploadAdpreportStatus> UploadAdpreportStatuses { get; set; }

    public virtual DbSet<UploadReportServiceLogger> UploadReportServiceLoggers { get; set; }

    public virtual DbSet<UploadedReportStatus> UploadedReportStatuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<User1> Users1 { get; set; }

    public virtual DbSet<UserAttandanceInspection> UserAttandanceInspections { get; set; }

    public virtual DbSet<UserAttendance> UserAttendances { get; set; }

    public virtual DbSet<UserAttendanceArea> UserAttendanceAreas { get; set; }

    public virtual DbSet<UserAttendanceControlCenter> UserAttendanceControlCenters { get; set; }

    public virtual DbSet<UserAttendanceLog> UserAttendanceLogs { get; set; }

    public virtual DbSet<UserAttendanceModificationReason> UserAttendanceModificationReasons { get; set; }

    public virtual DbSet<UserAttendanceReportView> UserAttendanceReportViews { get; set; }

    public virtual DbSet<UserAttendanceTrace> UserAttendanceTraces { get; set; }

    public virtual DbSet<UserCodesForgetPassword> UserCodesForgetPasswords { get; set; }

    public virtual DbSet<UserGuidView> UserGuidViews { get; set; }

    public virtual DbSet<UserNationalityCategoryDim> UserNationalityCategoryDims { get; set; }


    public virtual DbSet<UserReportsView> UserReportsViews { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    public virtual DbSet<UserView> UserViews { get; set; }

    public virtual DbSet<VEditIncidentAdp> VEditIncidentAdps { get; set; }

    public virtual DbSet<VEscortForOp> VEscortForOps { get; set; }

    public virtual DbSet<VFinancialInquiryReport> VFinancialInquiryReports { get; set; }

    public virtual DbSet<VGetDispatcherName> VGetDispatcherNames { get; set; }

    public virtual DbSet<VGetIncidentAreaByreport> VGetIncidentAreaByreports { get; set; }

    public virtual DbSet<VGetIncidentReason> VGetIncidentReasons { get; set; }

    public virtual DbSet<VGetReportCustomerChanel> VGetReportCustomerChanels { get; set; }

    public virtual DbSet<VGetReportCustomerChanelDetail> VGetReportCustomerChanelDetails { get; set; }

    public virtual DbSet<VGetReportCustomerChanelDetailsObjection> VGetReportCustomerChanelDetailsObjections { get; set; }

    public virtual DbSet<VGetReportCustomerChanelObjection> VGetReportCustomerChanelObjections { get; set; }

    public virtual DbSet<VGetRequestsList> VGetRequestsLists { get; set; }

    public virtual DbSet<VGetWhatsSmsretryLog> VGetWhatsSmsretryLogs { get; set; }

    public virtual DbSet<VIncidentDetail> VIncidentDetails { get; set; }

    public virtual DbSet<VIncidentWithAreaGroupList> VIncidentWithAreaGroupLists { get; set; }

    public virtual DbSet<VMdtConsentViewVehicleData> VMdtConsentViewVehicleDatas { get; set; }

    public virtual DbSet<VMdtViewReportDamagedProperty> VMdtViewReportDamagedProperties { get; set; }

    public virtual DbSet<VMdtViewReportWittness> VMdtViewReportWittnesses { get; set; }

    public virtual DbSet<VMdtViewVehicleData> VMdtViewVehicleDatas { get; set; }

    public virtual DbSet<VMdtaccidentReportBasicDetail> VMdtaccidentReportBasicDetails { get; set; }

    public virtual DbSet<VMissionPatrolStatusLogsForOperation> VMissionPatrolStatusLogsForOperations { get; set; }

    public virtual DbSet<VMobileRequestList> VMobileRequestLists { get; set; }

    public virtual DbSet<VObjectionFinancialReport> VObjectionFinancialReports { get; set; }

    public virtual DbSet<VObjectionStatisticsForIndividual> VObjectionStatisticsForIndividuals { get; set; }

    public virtual DbSet<VRenewReportDetail> VRenewReportDetails { get; set; }

    public virtual DbSet<VReportAccessLog> VReportAccessLogs { get; set; }

    public virtual DbSet<VReportDriverNumber> VReportDriverNumbers { get; set; }

    public virtual DbSet<VReportsForUploading> VReportsForUploadings { get; set; }

    public virtual DbSet<VReportsStatusAugust> VReportsStatusAugusts { get; set; }

    public virtual DbSet<VSaaedGetConsentIncidentList> VSaaedGetConsentIncidentLists { get; set; }

    public virtual DbSet<VSaaedTsgetCanceledIncident> VSaaedTsgetCanceledIncidents { get; set; }

    public virtual DbSet<VSaaedTsgetClosedIncidentList> VSaaedTsgetClosedIncidentLists { get; set; }

    public virtual DbSet<VSaaedTsgetClosedIncidentListOld> VSaaedTsgetClosedIncidentListOlds { get; set; }

    public virtual DbSet<VSaaedTsgetClosedIncidentListTest> VSaaedTsgetClosedIncidentListTests { get; set; }

    public virtual DbSet<VSketchReportDatum> VSketchReportData { get; set; }

    public virtual DbSet<VSmartDispatchingAreaConfiguration> VSmartDispatchingAreaConfigurations { get; set; }

    public virtual DbSet<VSmartDispatchingIncidentDetail> VSmartDispatchingIncidentDetails { get; set; }

    public virtual DbSet<VSmstoWhatsMapping> VSmstoWhatsMappings { get; set; }

    public virtual DbSet<VTeattendance> VTeattendances { get; set; }

    public virtual DbSet<VTerolsDetail> VTerolsDetails { get; set; }

    public virtual DbSet<VTrafficViolation> VTrafficViolations { get; set; }

    public virtual DbSet<VTrafficViolationDetail> VTrafficViolationDetails { get; set; }

    public virtual DbSet<VTranslatedPlateColorDim> VTranslatedPlateColorDims { get; set; }

    public virtual DbSet<VTranslatedPlateSourceDim> VTranslatedPlateSourceDims { get; set; }

    public virtual DbSet<VTsincidentDetail> VTsincidentDetails { get; set; }

    public virtual DbSet<VUnpaidreportFee> VUnpaidreportFees { get; set; }

    public virtual DbSet<VUploadAccidentCauseDatum> VUploadAccidentCauseData { get; set; }

    public virtual DbSet<VUploadAccidentDamagedGov> VUploadAccidentDamagedGovs { get; set; }

    public virtual DbSet<VUploadAccidentDamagedPart> VUploadAccidentDamagedParts { get; set; }

    public virtual DbSet<VUploadAccidentInvolvedDatum> VUploadAccidentInvolvedData { get; set; }

    public virtual DbSet<VUploadAccidentMasterDatum> VUploadAccidentMasterData { get; set; }

    public virtual DbSet<VUserandRoleContact> VUserandRoleContacts { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<VehicleBrandDim> VehicleBrandDims { get; set; }

    public virtual DbSet<VehicleCategoryDim> VehicleCategoryDims { get; set; }

    public virtual DbSet<VehicleCategoryToLicenseCategoryMap> VehicleCategoryToLicenseCategoryMaps { get; set; }

    public virtual DbSet<VehicleCategoryToVehicleTypeMap> VehicleCategoryToVehicleTypeMaps { get; set; }

    public virtual DbSet<VehicleDamagePart> VehicleDamageParts { get; set; }

    public virtual DbSet<VehicleDamagedPart> VehicleDamagedParts { get; set; }

    public virtual DbSet<VehicleDamagedTypeDim> VehicleDamagedTypeDims { get; set; }

    public virtual DbSet<VehicleDataTypeDim> VehicleDataTypeDims { get; set; }

    public virtual DbSet<VehicleDatum> VehicleData { get; set; }

    public virtual DbSet<VehicleEnergySourceDim> VehicleEnergySourceDims { get; set; }

    public virtual DbSet<VehicleGuidView> VehicleGuidViews { get; set; }

    public virtual DbSet<VehicleInvolvedSerial> VehicleInvolvedSerials { get; set; }

    public virtual DbSet<VehicleMatrix> VehicleMatrices { get; set; }

    public virtual DbSet<VehicleModelDim> VehicleModelDims { get; set; }

    public virtual DbSet<VehicleModelMatrix> VehicleModelMatrices { get; set; }

    public virtual DbSet<VehicleModelPoliceVechileModelDim> VehicleModelPoliceVechileModelDims { get; set; }

    public virtual DbSet<VehicleStatusDim> VehicleStatusDims { get; set; }

    public virtual DbSet<VehicleTypeDim> VehicleTypeDims { get; set; }

    public virtual DbSet<VehicleTypeDimcodeView> VehicleTypeDimcodeViews { get; set; }

    public virtual DbSet<VehicleTypeToVehicleModelMap> VehicleTypeToVehicleModelMaps { get; set; }

    public virtual DbSet<VehicleView> VehicleViews { get; set; }

    public virtual DbSet<VersionInfoDim> VersionInfoDims { get; set; }

    public virtual DbSet<Vessel> Vessels { get; set; }

    public virtual DbSet<VesselCategoryDim> VesselCategoryDims { get; set; }

    public virtual DbSet<VesselCategoryDimcodeView> VesselCategoryDimcodeViews { get; set; }

    public virtual DbSet<VesselGuidView> VesselGuidViews { get; set; }

    public virtual DbSet<VesselHullMaterialDim> VesselHullMaterialDims { get; set; }

    public virtual DbSet<VesselHullMaterialDimcodeView> VesselHullMaterialDimcodeViews { get; set; }

    public virtual DbSet<VesselHullShapeDim> VesselHullShapeDims { get; set; }

    public virtual DbSet<VesselHullShapeDimcodeView> VesselHullShapeDimcodeViews { get; set; }

    public virtual DbSet<VesselPropulsionTypeDim> VesselPropulsionTypeDims { get; set; }

    public virtual DbSet<VesselPropulsionTypeDimcodeView> VesselPropulsionTypeDimcodeViews { get; set; }

    public virtual DbSet<VesselView> VesselViews { get; set; }

    public virtual DbSet<Victim> Victims { get; set; }

    public virtual DbSet<VictimCategoryDim> VictimCategoryDims { get; set; }

    public virtual DbSet<VictimCategoryDimcodeView> VictimCategoryDimcodeViews { get; set; }

    public virtual DbSet<VictimGuidView> VictimGuidViews { get; set; }

    public virtual DbSet<VictimMeansOfAttackDim> VictimMeansOfAttackDims { get; set; }

    public virtual DbSet<VictimMeansOfAttackDimcodeView> VictimMeansOfAttackDimcodeViews { get; set; }

    public virtual DbSet<VictimView> VictimViews { get; set; }

    public virtual DbSet<ViewAccidentHistoryByChassisNumber> ViewAccidentHistoryByChassisNumbers { get; set; }

    public virtual DbSet<ViewActiveDirectoryPerson> ViewActiveDirectoryPersons { get; set; }

    public virtual DbSet<ViewActivityArrival1DelayReason> ViewActivityArrival1DelayReasons { get; set; }

    public virtual DbSet<ViewActivityArrival2Reason> ViewActivityArrival2Reasons { get; set; }

    public virtual DbSet<ViewActivityAssignment> ViewActivityAssignments { get; set; }

    public virtual DbSet<ViewActivityAssignmentDelayReason> ViewActivityAssignmentDelayReasons { get; set; }

    public virtual DbSet<ViewActivityAssignmentFull> ViewActivityAssignmentFulls { get; set; }

    public virtual DbSet<ViewActivityAssignmentPerson> ViewActivityAssignmentPeople { get; set; }

    public virtual DbSet<ViewActivityAssignmentSimple> ViewActivityAssignmentSimples { get; set; }

    public virtual DbSet<ViewActivityCreationDelayReason> ViewActivityCreationDelayReasons { get; set; }

    public virtual DbSet<ViewActivityDispatching> ViewActivityDispatchings { get; set; }

    public virtual DbSet<ViewActivityEndArcDelayReason> ViewActivityEndArcDelayReasons { get; set; }

    public virtual DbSet<ViewActivityGroupGi> ViewActivityGroupGis { get; set; }

    public virtual DbSet<ViewActivityGroupGisreport> ViewActivityGroupGisreports { get; set; }

    public virtual DbSet<ViewActivityResponsePerEmirate> ViewActivityResponsePerEmirates { get; set; }

    public virtual DbSet<ViewActivityTransactionStatusOrgDetail> ViewActivityTransactionStatusOrgDetails { get; set; }

    public virtual DbSet<ViewAssignedIncidentNew> ViewAssignedIncidentNews { get; set; }

    public virtual DbSet<ViewAssignedPatrolForNotification> ViewAssignedPatrolForNotifications { get; set; }

    public virtual DbSet<ViewAttendedPatrol> ViewAttendedPatrols { get; set; }

    public virtual DbSet<ViewAttendedPatrolLocation> ViewAttendedPatrolLocations { get; set; }

    public virtual DbSet<ViewClosedIncidentNew> ViewClosedIncidentNews { get; set; }

    public virtual DbSet<ViewContorlCenterRelatedArea> ViewContorlCenterRelatedAreas { get; set; }

    public virtual DbSet<ViewCustomerObjectionDocument> ViewCustomerObjectionDocuments { get; set; }

    public virtual DbSet<ViewElectronicInspection> ViewElectronicInspections { get; set; }

    public virtual DbSet<ViewElectronicInspectionForReport> ViewElectronicInspectionForReports { get; set; }

    public virtual DbSet<ViewElectronicInspectionReportDamage> ViewElectronicInspectionReportDamages { get; set; }

    public virtual DbSet<ViewElectronicInspectionReportDocument> ViewElectronicInspectionReportDocuments { get; set; }

    public virtual DbSet<ViewElectronicInspectionReportQuestionAnswer> ViewElectronicInspectionReportQuestionAnswers { get; set; }

    public virtual DbSet<ViewGetNewInicdnt> ViewGetNewInicdnts { get; set; }

    public virtual DbSet<ViewGetSupportOrganization> ViewGetSupportOrganizations { get; set; }

    public virtual DbSet<ViewIcccincidnetRequestList> ViewIcccincidnetRequestLists { get; set; }

    public virtual DbSet<ViewIcccincidnetRequestListClosed> ViewIcccincidnetRequestListCloseds { get; set; }

    public virtual DbSet<ViewIcccincidnetRequestListForAll> ViewIcccincidnetRequestListForAlls { get; set; }

    public virtual DbSet<ViewIncidentCall> ViewIncidentCalls { get; set; }

    public virtual DbSet<ViewIncidentCallForCompromise> ViewIncidentCallForCompromises { get; set; }

    public virtual DbSet<ViewIncidentCancelledPatrolSupport> ViewIncidentCancelledPatrolSupports { get; set; }

    public virtual DbSet<ViewIncidentCompromise> ViewIncidentCompromises { get; set; }

    public virtual DbSet<ViewIncidentConvertToStationReason> ViewIncidentConvertToStationReasons { get; set; }

    public virtual DbSet<ViewIncidentDetailForCompromise> ViewIncidentDetailForCompromises { get; set; }

    public virtual DbSet<ViewIncidentListObj> ViewIncidentListObjs { get; set; }

    public virtual DbSet<ViewIncidentNew> ViewIncidentNews { get; set; }

    public virtual DbSet<ViewIncidentPatrol> ViewIncidentPatrols { get; set; }

    public virtual DbSet<ViewIncidentPatrol1> ViewIncidentPatrol1s { get; set; }

    public virtual DbSet<ViewIncidentRelatedPatol> ViewIncidentRelatedPatols { get; set; }

    public virtual DbSet<ViewIncidentSupport> ViewIncidentSupports { get; set; }

    public virtual DbSet<ViewIncidentWorkFlow> ViewIncidentWorkFlows { get; set; }

    public virtual DbSet<ViewIncidentWorkFlowNew> ViewIncidentWorkFlowNews { get; set; }

    public virtual DbSet<ViewLogedInPatrol> ViewLogedInPatrols { get; set; }

    public virtual DbSet<ViewLookupDamagedPart> ViewLookupDamagedParts { get; set; }

    public virtual DbSet<ViewLookupVehicleBrand> ViewLookupVehicleBrands { get; set; }

    public virtual DbSet<ViewLookupVehicleModel> ViewLookupVehicleModels { get; set; }

    public virtual DbSet<ViewMaxIncidentTransaction> ViewMaxIncidentTransactions { get; set; }

    public virtual DbSet<ViewMdtareaItemSyncHelper> ViewMdtareaItemSyncHelpers { get; set; }

    public virtual DbSet<ViewMdtcontactSyncHelper> ViewMdtcontactSyncHelpers { get; set; }

    public virtual DbSet<ViewMdtincidentRelatedPatol> ViewMdtincidentRelatedPatols { get; set; }

    public virtual DbSet<ViewMdtmembershipSyncHelper> ViewMdtmembershipSyncHelpers { get; set; }

    public virtual DbSet<ViewMdtorganizationPersonSyncHelper> ViewMdtorganizationPersonSyncHelpers { get; set; }

    public virtual DbSet<ViewMdtpersonAreaSyncHelper> ViewMdtpersonAreaSyncHelpers { get; set; }

    public virtual DbSet<ViewMdtpersonAspnetUserSyncHelper> ViewMdtpersonAspnetUserSyncHelpers { get; set; }

    public virtual DbSet<ViewMdtpersonContactSyncHelper> ViewMdtpersonContactSyncHelpers { get; set; }

    public virtual DbSet<ViewMdtusersInRolesSyncHelper> ViewMdtusersInRolesSyncHelpers { get; set; }

    public virtual DbSet<ViewMdtusersSyncHelper> ViewMdtusersSyncHelpers { get; set; }

    public virtual DbSet<ViewMissionDetail> ViewMissionDetails { get; set; }

    public virtual DbSet<ViewMissionDetailForAndroid> ViewMissionDetailForAndroids { get; set; }

    public virtual DbSet<ViewMissionDetailReport> ViewMissionDetailReports { get; set; }

    public virtual DbSet<ViewMobileIncidentRequest> ViewMobileIncidentRequests { get; set; }

    public virtual DbSet<ViewMobileRequestList> ViewMobileRequestLists { get; set; }

    public virtual DbSet<ViewMoiintegration> ViewMoiintegrations { get; set; }

    public virtual DbSet<ViewMoiintegrationObjection> ViewMoiintegrationObjections { get; set; }

    public virtual DbSet<ViewNewIncidentObj> ViewNewIncidentObjs { get; set; }

    public virtual DbSet<ViewNotUploadedReport> ViewNotUploadedReports { get; set; }

    public virtual DbSet<ViewObjection> ViewObjections { get; set; }

    public virtual DbSet<ViewObjectionComment> ViewObjectionComments { get; set; }

    public virtual DbSet<ViewObjectionDocument> ViewObjectionDocuments { get; set; }

    public virtual DbSet<ViewObjectionsPayment> ViewObjectionsPayments { get; set; }

    public virtual DbSet<ViewOpenIncidentNew> ViewOpenIncidentNews { get; set; }

    public virtual DbSet<ViewPatrolsInMission> ViewPatrolsInMissions { get; set; }

    public virtual DbSet<ViewPersonArea> ViewPersonAreas { get; set; }

    public virtual DbSet<ViewPersonControlRoomAreaDetailsByCategory> ViewPersonControlRoomAreaDetailsByCategories { get; set; }

    public virtual DbSet<ViewPersonControlRoomAreaDetailsByRole> ViewPersonControlRoomAreaDetailsByRoles { get; set; }

    public virtual DbSet<ViewPersonRole> ViewPersonRoles { get; set; }

    public virtual DbSet<ViewPoliceReport> ViewPoliceReports { get; set; }

    public virtual DbSet<ViewRenewReport> ViewRenewReports { get; set; }

    public virtual DbSet<ViewRepairPermission> ViewRepairPermissions { get; set; }

    public virtual DbSet<ViewReportRequest> ViewReportRequests { get; set; }

    public virtual DbSet<ViewRequestedMission> ViewRequestedMissions { get; set; }

    public virtual DbSet<ViewSaaedIncidentTransaction> ViewSaaedIncidentTransactions { get; set; }

    public virtual DbSet<ViewSaaedTransferedReport> ViewSaaedTransferedReports { get; set; }

    public virtual DbSet<ViewSmsretry> ViewSmsretries { get; set; }

    public virtual DbSet<ViewSupervisorClosedIncident> ViewSupervisorClosedIncidents { get; set; }

    public virtual DbSet<ViewSupervisorMapIncident> ViewSupervisorMapIncidents { get; set; }

    public virtual DbSet<ViewSupervisorMapIncidentsForAll> ViewSupervisorMapIncidentsForAlls { get; set; }

    public virtual DbSet<ViewSupervisorOpenedIncident> ViewSupervisorOpenedIncidents { get; set; }

    public virtual DbSet<ViewTicketRequest> ViewTicketRequests { get; set; }

    public virtual DbSet<ViewUnderProcessLog> ViewUnderProcessLogs { get; set; }

    public virtual DbSet<ViewUpdateIncidentList> ViewUpdateIncidentLists { get; set; }

    public virtual DbSet<Violation> Violations { get; set; }

    public virtual DbSet<ViolationAttachement> ViolationAttachements { get; set; }

    public virtual DbSet<ViolationStepDim> ViolationStepDims { get; set; }

    public virtual DbSet<ViolationTypeDim> ViolationTypeDims { get; set; }

    public virtual DbSet<ViolationVehicleDatum> ViolationVehicleData { get; set; }

    public virtual DbSet<ViolationsStep> ViolationsSteps { get; set; }

    public virtual DbSet<ViolationsStepsRole> ViolationsStepsRoles { get; set; }

    public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }

    public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; }

    public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; }

    public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; }

    public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }

    public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; }

    public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; }

    public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; }

    public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; }

    public virtual DbSet<VwAttendanceHistoryLog> VwAttendanceHistoryLogs { get; set; }

    public virtual DbSet<VwBranchesSaaed> VwBranchesSaaeds { get; set; }

    public virtual DbSet<VwDriverAccident> VwDriverAccidents { get; set; }

    public virtual DbSet<VwIncidentArcfullDetail> VwIncidentArcfullDetails { get; set; }

    public virtual DbSet<VwIncidentRelatedItem> VwIncidentRelatedItems { get; set; }

    public virtual DbSet<VwIncidentsFullDetail> VwIncidentsFullDetails { get; set; }

    public virtual DbSet<VwIncidentsFullDetailsSupport> VwIncidentsFullDetailsSupports { get; set; }

    public virtual DbSet<VwPatrolWorkflow> VwPatrolWorkflows { get; set; }

    public virtual DbSet<VwTran> VwTrans { get; set; }

    public virtual DbSet<VwTransportersSaaed> VwTransportersSaaeds { get; set; }

    public virtual DbSet<VwUserBasicInfo> VwUserBasicInfos { get; set; }

    public virtual DbSet<VwUserCheckupActivityRole> VwUserCheckupActivityRoles { get; set; }

    public virtual DbSet<VwUserLoginLastActivity> VwUserLoginLastActivities { get; set; }

    public virtual DbSet<VwUserRole> VwUserRoles { get; set; }

    public virtual DbSet<Warrant> Warrants { get; set; }

    public virtual DbSet<WarrantAppearanceBail> WarrantAppearanceBails { get; set; }

    public virtual DbSet<WarrantAppearanceBailContainerGuidView> WarrantAppearanceBailContainerGuidViews { get; set; }

    public virtual DbSet<WarrantAppearanceBailContainerView> WarrantAppearanceBailContainerViews { get; set; }

    public virtual DbSet<WarrantAppearanceBailForfeitDim> WarrantAppearanceBailForfeitDims { get; set; }

    public virtual DbSet<WarrantAppearanceBailForfeitDimcodeView> WarrantAppearanceBailForfeitDimcodeViews { get; set; }

    public virtual DbSet<WarrantCategoryDim> WarrantCategoryDims { get; set; }

    public virtual DbSet<WarrantCategoryDimcodeView> WarrantCategoryDimcodeViews { get; set; }

    public virtual DbSet<WarrantExtraditionLimitationDim> WarrantExtraditionLimitationDims { get; set; }

    public virtual DbSet<WarrantExtraditionLimitationDimcodeView> WarrantExtraditionLimitationDimcodeViews { get; set; }

    public virtual DbSet<WarrantFurtherProcessingDim> WarrantFurtherProcessingDims { get; set; }

    public virtual DbSet<WarrantFurtherProcessingDimcodeView> WarrantFurtherProcessingDimcodeViews { get; set; }

    public virtual DbSet<WarrantLevelDim> WarrantLevelDims { get; set; }

    public virtual DbSet<WarrantLevelDimcodeView> WarrantLevelDimcodeViews { get; set; }

    public virtual DbSet<WarrantProbableCauseDim> WarrantProbableCauseDims { get; set; }

    public virtual DbSet<WarrantProbableCauseDimcodeView> WarrantProbableCauseDimcodeViews { get; set; }

    public virtual DbSet<WeatherDim> WeatherDims { get; set; }

    public virtual DbSet<WebApiRequestsLog> WebApiRequestsLogs { get; set; }

    public virtual DbSet<WeightMeasureUnitDim> WeightMeasureUnitDims { get; set; }

    public virtual DbSet<WeightMeasureUnitDimcodeView> WeightMeasureUnitDimcodeViews { get; set; }

    public virtual DbSet<WfdelayTimeSpanView> WfdelayTimeSpanViews { get; set; }

    public virtual DbSet<Wittness> Wittnesses { get; set; }

    public virtual DbSet<WorkerProcessLog> WorkerProcessLogs { get; set; }

    public virtual DbSet<WorkflowInstanceEventsTable> WorkflowInstanceEventsTables { get; set; }

    public virtual DbSet<YearDim> YearDims { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https:go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https:go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-D84QCS0;Database=Saaed360DBLive2;User Id=sa;Password=Amr_1994;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Delegate all entity configurations to the ModelConfiguration class
        new ModelConfiguration().Apply(modelBuilder);
        OnModelCreatingPartial(modelBuilder);

    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
