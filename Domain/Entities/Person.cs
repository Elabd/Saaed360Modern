using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Person
{
    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public string Description { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int? PersonStatusId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Moniker { get; set; }

    public string? Suffix { get; set; }

    public string? Prefix { get; set; }

    public int? PersonCategoryId { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool? IsFromActiveDirectory { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityArea> ActivityAreaCreatedByNavigations { get; set; } = new List<ActivityArea>();

    public virtual ICollection<ActivityArea> ActivityAreaModifiedByNavigations { get; set; } = new List<ActivityArea>();

    public virtual ICollection<ActivityAssociation> ActivityAssociationCreatedByNavigations { get; set; } = new List<ActivityAssociation>();

    public virtual ICollection<ActivityAssociation> ActivityAssociationModifiedByNavigations { get; set; } = new List<ActivityAssociation>();

    public virtual ICollection<ActivityComment> ActivityCommentCreatedByNavigations { get; set; } = new List<ActivityComment>();

    public virtual ICollection<ActivityComment> ActivityCommentModifiedByNavigations { get; set; } = new List<ActivityComment>();

    public virtual ICollection<ActivityConvertToStation> ActivityConvertToStations { get; set; } = new List<ActivityConvertToStation>();

    public virtual ICollection<ActivityItem> ActivityItemCreatedByNavigations { get; set; } = new List<ActivityItem>();

    public virtual ICollection<ActivityItem> ActivityItemModifiedByNavigations { get; set; } = new List<ActivityItem>();

    public virtual ICollection<ActivityItemStatusLocation> ActivityItemStatusLocations { get; set; } = new List<ActivityItemStatusLocation>();

    public virtual ICollection<ActivityLocation> ActivityLocationCreatedByNavigations { get; set; } = new List<ActivityLocation>();

    public virtual ICollection<ActivityLocation> ActivityLocationModifiedByNavigations { get; set; } = new List<ActivityLocation>();

    public virtual ICollection<ActivityLog> ActivityLogCreatedByNavigations { get; set; } = new List<ActivityLog>();

    public virtual ICollection<ActivityLog> ActivityLogModifiedByNavigations { get; set; } = new List<ActivityLog>();

    public virtual ICollection<ActivityOrganization> ActivityOrganizationCreatedByNavigations { get; set; } = new List<ActivityOrganization>();

    public virtual ICollection<ActivityOrganization> ActivityOrganizationModifiedByNavigations { get; set; } = new List<ActivityOrganization>();

    public virtual ICollection<ActivityPerson> ActivityPersonCreatedByNavigations { get; set; } = new List<ActivityPerson>();

    public virtual ICollection<ActivityPerson> ActivityPersonModifiedByNavigations { get; set; } = new List<ActivityPerson>();

    public virtual ICollection<ActivityPerson> ActivityPersonPeople { get; set; } = new List<ActivityPerson>();

    public virtual ICollection<ActivityReport> ActivityReports { get; set; } = new List<ActivityReport>();

    public virtual ICollection<ActivityTransaction> ActivityTransactionCreatedByNavigations { get; set; } = new List<ActivityTransaction>();

    public virtual ICollection<ActivityTransaction> ActivityTransactionTes { get; set; } = new List<ActivityTransaction>();

    public virtual ICollection<ApprovalCycle> ApprovalCycleCreatedByNavigations { get; set; } = new List<ApprovalCycle>();

    public virtual ICollection<ApprovalCycle> ApprovalCycleModifiedByNavigations { get; set; } = new List<ApprovalCycle>();

    public virtual ICollection<AreaAssociation> AreaAssociationCreatedByNavigations { get; set; } = new List<AreaAssociation>();

    public virtual ICollection<AreaAssociation> AreaAssociationModifiedByNavigations { get; set; } = new List<AreaAssociation>();

    public virtual ICollection<Area> AreaCreatedByNavigations { get; set; } = new List<Area>();

    public virtual ICollection<Area> AreaModifiedByNavigations { get; set; } = new List<Area>();

    public virtual ICollection<Comment> CommentCreatedByNavigations { get; set; } = new List<Comment>();

    public virtual ICollection<Comment> CommentModifiedByNavigations { get; set; } = new List<Comment>();

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ICollection<DamagedProperty> DamagedProperties { get; set; } = new List<DamagedProperty>();

    public virtual ICollection<DamagedVehiclePart> DamagedVehicleParts { get; set; } = new List<DamagedVehiclePart>();

    public virtual ICollection<DriverDatum> DriverData { get; set; } = new List<DriverDatum>();

    public virtual ICollection<DriverDataConfiscationLog> DriverDataConfiscationLogCreatedByNavigations { get; set; } = new List<DriverDataConfiscationLog>();

    public virtual ICollection<DriverDataConfiscationLog> DriverDataConfiscationLogModifiedByNavigations { get; set; } = new List<DriverDataConfiscationLog>();

    public virtual ICollection<ElectronicInspectionPatrolAttendance> ElectronicInspectionPatrolAttendances { get; set; } = new List<ElectronicInspectionPatrolAttendance>();

    public virtual ICollection<ElectronicInspectionReportAnswer> ElectronicInspectionReportAnswers { get; set; } = new List<ElectronicInspectionReportAnswer>();

    public virtual ICollection<ElectronicInspectionReportDamagePart> ElectronicInspectionReportDamageParts { get; set; } = new List<ElectronicInspectionReportDamagePart>();

    public virtual EnforcementOfficial? EnforcementOfficial { get; set; }

    public virtual ICollection<EscortMissionEmployee> EscortMissionEmployees { get; set; } = new List<EscortMissionEmployee>();

    public virtual ICollection<EscortMissionPatrolEmployee> EscortMissionPatrolEmployees { get; set; } = new List<EscortMissionPatrolEmployee>();

    public virtual ICollection<EscortingReportBasicDetail> EscortingReportBasicDetails { get; set; } = new List<EscortingReportBasicDetail>();

    public virtual ICollection<EventIncidentAction> EventIncidentActionCreatedByNavigations { get; set; } = new List<EventIncidentAction>();

    public virtual ICollection<EventIncidentAction> EventIncidentActionModificationByNavigations { get; set; } = new List<EventIncidentAction>();

    public virtual ICollection<EventIncidentComment> EventIncidentCommentCreatedByNavigations { get; set; } = new List<EventIncidentComment>();

    public virtual ICollection<EventIncidentComment> EventIncidentCommentModificationByNavigations { get; set; } = new List<EventIncidentComment>();

    public virtual ICollection<EventIncidentImage> EventIncidentImageCreatedByNavigations { get; set; } = new List<EventIncidentImage>();

    public virtual ICollection<EventIncidentImage> EventIncidentImageModificationByNavigations { get; set; } = new List<EventIncidentImage>();

    public virtual ICollection<EventIncident> EventIncidentModificationByNavigations { get; set; } = new List<EventIncident>();

    public virtual ICollection<EventIncident> EventIncidentPeople { get; set; } = new List<EventIncident>();

    public virtual ICollection<EventIncidentPerson> EventIncidentPersonCreatedByNavigations { get; set; } = new List<EventIncidentPerson>();

    public virtual ICollection<EventIncidentPerson> EventIncidentPersonModificationByNavigations { get; set; } = new List<EventIncidentPerson>();

    public virtual ICollection<EventIncidentsStatusLog> EventIncidentsStatusLogs { get; set; } = new List<EventIncidentsStatusLog>();

    public virtual ICollection<EventMissionAssignmentLog> EventMissionAssignmentLogs { get; set; } = new List<EventMissionAssignmentLog>();

    public virtual ICollection<EventSourcePerson> EventSourcePeople { get; set; } = new List<EventSourcePerson>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<EventsArea> EventsAreas { get; set; } = new List<EventsArea>();

    public virtual ICollection<EventsEmployeesAttendance> EventsEmployeesAttendanceCreatedByNavigations { get; set; } = new List<EventsEmployeesAttendance>();

    public virtual ICollection<EventsEmployeesAttendance> EventsEmployeesAttendanceEmployees { get; set; } = new List<EventsEmployeesAttendance>();

    public virtual ICollection<EventsMissionAssignment> EventsMissionAssignmentCreatedByNavigations { get; set; } = new List<EventsMissionAssignment>();

    public virtual ICollection<EventsMissionAssignment> EventsMissionAssignmentModifiedByNavigations { get; set; } = new List<EventsMissionAssignment>();

    public virtual ICollection<EventsMissionAssignment> EventsMissionAssignmentPeople { get; set; } = new List<EventsMissionAssignment>();

    public virtual ICollection<EventsMission> EventsMissionCreatedByNavigations { get; set; } = new List<EventsMission>();

    public virtual ICollection<EventsMission> EventsMissionModifiedByNavigations { get; set; } = new List<EventsMission>();

    public virtual ICollection<EventsMissionsStatusLog> EventsMissionsStatusLogs { get; set; } = new List<EventsMissionsStatusLog>();

    public virtual ICollection<EventsPatrol> EventsPatrols { get; set; } = new List<EventsPatrol>();

    public virtual ICollection<EventsPerson> EventsPersonCreatedByNavigations { get; set; } = new List<EventsPerson>();

    public virtual ICollection<EventsPerson> EventsPersonPeople { get; set; } = new List<EventsPerson>();

    public virtual ICollection<EventsStatusLog> EventsStatusLogs { get; set; } = new List<EventsStatusLog>();

    public virtual ICollection<EventsSupervisor> EventsSupervisorCreatedByNavigations { get; set; } = new List<EventsSupervisor>();

    public virtual ICollection<EventsSupervisor> EventsSupervisorPeople { get; set; } = new List<EventsSupervisor>();

    public virtual ICollection<Evidence> Evidences { get; set; } = new List<Evidence>();

    //public virtual ICollection<File> FileCreatedByNavigations { get; set; } = new List<File>();

    //public virtual ICollection<File> FileModifiedByNavigations { get; set; } = new List<File>();

    public virtual ICollection<FmsbranchUser> FmsbranchUsers { get; set; } = new List<FmsbranchUser>();

    public virtual ICollection<FmssubBranchUser> FmssubBranchUsers { get; set; } = new List<FmssubBranchUser>();

    public virtual ICollection<IcccincidentLog> IcccincidentLogs { get; set; } = new List<IcccincidentLog>();

    public virtual ICollection<IcccincidentRequest> IcccincidentRequests { get; set; } = new List<IcccincidentRequest>();

    public virtual ICollection<IcccpoliceIncident> IcccpoliceIncidents { get; set; } = new List<IcccpoliceIncident>();

    public virtual ICollection<IcccrequestComment> IcccrequestComments { get; set; } = new List<IcccrequestComment>();

    public virtual ICollection<Person> InverseCreatedByNavigation { get; set; } = new List<Person>();

    public virtual ICollection<Person> InverseModifiedByNavigation { get; set; } = new List<Person>();

    public virtual ICollection<Item> ItemCreatedByNavigations { get; set; } = new List<Item>();

    public virtual ICollection<ItemLocation> ItemLocationCreatedByNavigations { get; set; } = new List<ItemLocation>();

    public virtual ICollection<ItemLocation> ItemLocationModifiedByNavigations { get; set; } = new List<ItemLocation>();

    public virtual ICollection<Item> ItemModifiedByNavigations { get; set; } = new List<Item>();

    public virtual JudicialOfficial? JudicialOfficial { get; set; }

    public virtual Juror? Juror { get; set; }

    public virtual ICollection<LocationArea> LocationAreaCreatedByNavigations { get; set; } = new List<LocationArea>();

    public virtual ICollection<LocationArea> LocationAreaModifiedByNavigations { get; set; } = new List<LocationArea>();

    public virtual ICollection<LocationComment> LocationCommentCreatedByNavigations { get; set; } = new List<LocationComment>();

    public virtual ICollection<LocationComment> LocationCommentModifiedByNavigations { get; set; } = new List<LocationComment>();

    public virtual ICollection<LogedInPatrol> LogedInPatrols { get; set; } = new List<LogedInPatrol>();

    public virtual ICollection<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; } = new List<MdtaccidentBasicDetail>();

    public virtual ICollection<MissingPerson> MissingPersonDeclarationPeople { get; set; } = new List<MissingPerson>();

    public virtual MissingPerson? MissingPersonPerson { get; set; }

    public virtual ICollection<MobileRequestReportPlanningStatusLog> MobileRequestReportPlanningStatusLogs { get; set; } = new List<MobileRequestReportPlanningStatusLog>();

    public virtual ICollection<MobileRequestTransaction> MobileRequestTransactions { get; set; } = new List<MobileRequestTransaction>();

    public virtual ICollection<MobileRequest> MobileRequests { get; set; } = new List<MobileRequest>();

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<ObjectionCommentLog> ObjectionCommentLogs { get; set; } = new List<ObjectionCommentLog>();

    public virtual ICollection<ObjectionLog> ObjectionLogs { get; set; } = new List<ObjectionLog>();

    public virtual ICollection<OrganizationAssociation> OrganizationAssociationCreatedByNavigations { get; set; } = new List<OrganizationAssociation>();

    public virtual ICollection<OrganizationAssociation> OrganizationAssociationModifiedByNavigations { get; set; } = new List<OrganizationAssociation>();

    public virtual ICollection<OrganizationComment> OrganizationCommentCreatedByNavigations { get; set; } = new List<OrganizationComment>();

    public virtual ICollection<OrganizationComment> OrganizationCommentModifiedByNavigations { get; set; } = new List<OrganizationComment>();

    public virtual ICollection<Organization> OrganizationCreatedByNavigations { get; set; } = new List<Organization>();

    public virtual ICollection<OrganizationItem> OrganizationItemCreatedByNavigations { get; set; } = new List<OrganizationItem>();

    public virtual ICollection<OrganizationItem> OrganizationItemModifiedByNavigations { get; set; } = new List<OrganizationItem>();

    public virtual ICollection<OrganizationLocation> OrganizationLocationCreatedByNavigations { get; set; } = new List<OrganizationLocation>();

    public virtual ICollection<OrganizationLocation> OrganizationLocationModifiedByNavigations { get; set; } = new List<OrganizationLocation>();

    public virtual ICollection<Organization> OrganizationModifiedByNavigations { get; set; } = new List<Organization>();

    public virtual ICollection<OrganizationPerson> OrganizationPersonCreatedByNavigations { get; set; } = new List<OrganizationPerson>();

    public virtual ICollection<OrganizationPerson> OrganizationPersonModifiedByNavigations { get; set; } = new List<OrganizationPerson>();

    public virtual ICollection<OrganizationPerson> OrganizationPersonPeople { get; set; } = new List<OrganizationPerson>();

    public virtual ICollection<OrganizationReason> OrganizationReasonCreatedByNavigations { get; set; } = new List<OrganizationReason>();

    public virtual ICollection<OrganizationReason> OrganizationReasonModifiedByNavigations { get; set; } = new List<OrganizationReason>();

    public virtual ICollection<OwnerDatum> OwnerData { get; set; } = new List<OwnerDatum>();

    public virtual ICollection<PersonAffiliation> PersonAffiliations { get; set; } = new List<PersonAffiliation>();

    public virtual ICollection<PersonAlias> PersonAliases { get; set; } = new List<PersonAlias>();

    public virtual ICollection<PersonArea> PersonAreas { get; set; } = new List<PersonArea>();

    public virtual ICollection<PersonAspnetUser> PersonAspnetUsers { get; set; } = new List<PersonAspnetUser>();

    public virtual ICollection<PersonCitizenship> PersonCitizenships { get; set; } = new List<PersonCitizenship>();

    public virtual ICollection<PersonClothing> PersonClothings { get; set; } = new List<PersonClothing>();

    public virtual ICollection<PersonComment> PersonCommentCreatedByNavigations { get; set; } = new List<PersonComment>();

    public virtual ICollection<PersonCommentNew01> PersonCommentNew01CreatedByNavigations { get; set; } = new List<PersonCommentNew01>();

    public virtual ICollection<PersonCommentNew01> PersonCommentNew01People { get; set; } = new List<PersonCommentNew01>();

    public virtual ICollection<PersonComment> PersonCommentPeople { get; set; } = new List<PersonComment>();

    public virtual ICollection<PersonContact> PersonContacts { get; set; } = new List<PersonContact>();

    public virtual ICollection<PersonDocument> PersonDocuments { get; set; } = new List<PersonDocument>();

    public virtual PersonDriverLicense? PersonDriverLicense { get; set; }

    public virtual ICollection<PersonEducation> PersonEducations { get; set; } = new List<PersonEducation>();

    public virtual ICollection<PersonEmployment> PersonEmploymentEmployerPeople { get; set; } = new List<PersonEmployment>();

    public virtual ICollection<PersonEmployment> PersonEmploymentPeople { get; set; } = new List<PersonEmployment>();

    public virtual ICollection<PersonFingerprintSet> PersonFingerprintSets { get; set; } = new List<PersonFingerprintSet>();

    public virtual ICollection<PersonHistoricalLocation> PersonHistoricalLocations { get; set; } = new List<PersonHistoricalLocation>();

    public virtual ICollection<PersonHistoricalTokenShared> PersonHistoricalTokenShareds { get; set; } = new List<PersonHistoricalTokenShared>();

    public virtual ICollection<PersonImage> PersonImages { get; set; } = new List<PersonImage>();

    public virtual ICollection<PersonInjury> PersonInjuries { get; set; } = new List<PersonInjury>();

    public virtual ICollection<PersonIntoxication> PersonIntoxications { get; set; } = new List<PersonIntoxication>();

    public virtual ICollection<PersonItem> PersonItemCreatedByNavigations { get; set; } = new List<PersonItem>();

    public virtual ICollection<PersonItem> PersonItemModifiedByNavigations { get; set; } = new List<PersonItem>();

    public virtual ICollection<PersonItem> PersonItemPeople { get; set; } = new List<PersonItem>();

    public virtual ICollection<PersonLanguage> PersonLanguages { get; set; } = new List<PersonLanguage>();

    public virtual ICollection<PersonLocation> PersonLocations { get; set; } = new List<PersonLocation>();

    public virtual ICollection<PersonMedicalCondition> PersonMedicalConditions { get; set; } = new List<PersonMedicalCondition>();

    public virtual ICollection<PersonMilitarySummary> PersonMilitarySummaries { get; set; } = new List<PersonMilitarySummary>();

    public virtual ICollection<PersonNationality> PersonNationalities { get; set; } = new List<PersonNationality>();

    public virtual ICollection<PersonOtherIdentification> PersonOtherIdentifications { get; set; } = new List<PersonOtherIdentification>();

    public virtual PersonPhysicalDetail? PersonPhysicalDetail { get; set; }

    public virtual ICollection<PersonPhysicalFeature> PersonPhysicalFeatures { get; set; } = new List<PersonPhysicalFeature>();

    public virtual ICollection<PersonRelationship> PersonRelationshipPeople { get; set; } = new List<PersonRelationship>();

    public virtual ICollection<PersonRelationship> PersonRelationshipPersonRelateds { get; set; } = new List<PersonRelationship>();

    public virtual ICollection<PersonReportsAssignment> PersonReportsAssignments { get; set; } = new List<PersonReportsAssignment>();

    public virtual ICollection<PersonSocialMedium> PersonSocialMedia { get; set; } = new List<PersonSocialMedium>();

    public virtual PersonStatusDim? PersonStatus { get; set; }

    public virtual ICollection<PersonTooth> PersonTeeth { get; set; } = new List<PersonTooth>();

    public virtual PersonVitalStatistic? PersonVitalStatistic { get; set; }

    public virtual ICollection<PhysicalAppearanceHistory> PhysicalAppearanceHistories { get; set; } = new List<PhysicalAppearanceHistory>();

    public virtual ICollection<PurchaseRequestComment> PurchaseRequestComments { get; set; } = new List<PurchaseRequestComment>();

    public virtual ICollection<PurchaseRequestLog> PurchaseRequestLogs { get; set; } = new List<PurchaseRequestLog>();

    public virtual ICollection<PurchaseRequest> PurchaseRequests { get; set; } = new List<PurchaseRequest>();

    public virtual ICollection<RecalculationRequestAttachment> RecalculationRequestAttachments { get; set; } = new List<RecalculationRequestAttachment>();

    public virtual ICollection<RecalculationRequest> RecalculationRequests { get; set; } = new List<RecalculationRequest>();

    public virtual ICollection<ReconstructionGraph> ReconstructionGraphs { get; set; } = new List<ReconstructionGraph>();

    public virtual ICollection<ReconstructionMap> ReconstructionMaps { get; set; } = new List<ReconstructionMap>();

    public virtual ICollection<RepairComment> RepairComments { get; set; } = new List<RepairComment>();

    public virtual RepairGaragePerson? RepairGaragePerson { get; set; }

    public virtual ICollection<RepairImage> RepairImageLastModifiedByNavigations { get; set; } = new List<RepairImage>();

    public virtual ICollection<RepairImage> RepairImageUploadByPeople { get; set; } = new List<RepairImage>();

    public virtual ICollection<RepairInvoice> RepairInvoices { get; set; } = new List<RepairInvoice>();

    public virtual ICollection<RepairLog> RepairLogs { get; set; } = new List<RepairLog>();

    public virtual ICollection<RepairQuote> RepairQuotes { get; set; } = new List<RepairQuote>();

    public virtual ICollection<RepairRequestGarageStatusHistory> RepairRequestGarageStatusHistories { get; set; } = new List<RepairRequestGarageStatusHistory>();

    public virtual ICollection<RepairRequest> RepairRequests { get; set; } = new List<RepairRequest>();

    public virtual ICollection<ReportActionTaken> ReportActionTakens { get; set; } = new List<ReportActionTaken>();

    public virtual ICollection<ReportChangeStatusLog> ReportChangeStatusLogs { get; set; } = new List<ReportChangeStatusLog>();

    public virtual ICollection<ReportDamagedProperty> ReportDamagedProperties { get; set; } = new List<ReportDamagedProperty>();

    public virtual ICollection<ReportField> ReportFieldCreatedByNavigations { get; set; } = new List<ReportField>();

    public virtual ICollection<ReportField> ReportFieldModifiedByNavigations { get; set; } = new List<ReportField>();

    public virtual ICollection<ReportGroup> ReportGroupCreatedByNavigations { get; set; } = new List<ReportGroup>();

    public virtual ICollection<ReportGroup> ReportGroupModifiedByNavigations { get; set; } = new List<ReportGroup>();

    public virtual ICollection<ReportImage> ReportImages { get; set; } = new List<ReportImage>();

    public virtual ICollection<ReportMdtAccidentBasicDetail> ReportMdtAccidentBasicDetails { get; set; } = new List<ReportMdtAccidentBasicDetail>();

    public virtual ICollection<ReportModifcationLogComment> ReportModifcationLogCommentCreatedByNavigations { get; set; } = new List<ReportModifcationLogComment>();

    public virtual ICollection<ReportModifcationLogComment> ReportModifcationLogCommentModifiedByNavigations { get; set; } = new List<ReportModifcationLogComment>();

    public virtual ICollection<ReportModificationAssociation> ReportModificationAssociationCreatedByNavigations { get; set; } = new List<ReportModificationAssociation>();

    public virtual ICollection<ReportModificationAssociation> ReportModificationAssociationModifiedByNavigations { get; set; } = new List<ReportModificationAssociation>();

    public virtual ICollection<ReportModification> ReportModificationCreatedByNavigations { get; set; } = new List<ReportModification>();

    public virtual ICollection<ReportModificationLog> ReportModificationLogCreatedByNavigations { get; set; } = new List<ReportModificationLog>();

    public virtual ICollection<ReportModificationLog> ReportModificationLogModifiedByNavigations { get; set; } = new List<ReportModificationLog>();

    public virtual ICollection<ReportModification> ReportModificationModifiedByNavigations { get; set; } = new List<ReportModification>();

    public virtual ICollection<ReportReconstructionPlan> ReportReconstructionPlans { get; set; } = new List<ReportReconstructionPlan>();

    public virtual ICollection<ReportRequestClientDatum> ReportRequestClientDatumCreatedByNavigations { get; set; } = new List<ReportRequestClientDatum>();

    public virtual ICollection<ReportRequestClientDatum> ReportRequestClientDatumModifiedByNavigations { get; set; } = new List<ReportRequestClientDatum>();

    public virtual ICollection<ReportRequestComment> ReportRequestCommentCreatedByNavigations { get; set; } = new List<ReportRequestComment>();

    public virtual ICollection<ReportRequestComment> ReportRequestCommentModifiedByNavigations { get; set; } = new List<ReportRequestComment>();

    public virtual ICollection<ReportRequest> ReportRequestCreatedByNavigations { get; set; } = new List<ReportRequest>();

    public virtual ICollection<ReportRequestDocument> ReportRequestDocumentCreatedByNavigations { get; set; } = new List<ReportRequestDocument>();

    public virtual ICollection<ReportRequestDocument> ReportRequestDocumentModifiedByNavigations { get; set; } = new List<ReportRequestDocument>();

    public virtual ICollection<ReportRequest> ReportRequestModifiedByNavigations { get; set; } = new List<ReportRequest>();

    public virtual ICollection<ReportRequest> ReportRequestTransferedByNavigations { get; set; } = new List<ReportRequest>();

    public virtual ICollection<ReportVehicleDatum> ReportVehicleData { get; set; } = new List<ReportVehicleDatum>();

    public virtual ICollection<ReportWittness> ReportWittnesses { get; set; } = new List<ReportWittness>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SecuritySituationAttachement> SecuritySituationAttachementCreatedByNavigations { get; set; } = new List<SecuritySituationAttachement>();

    public virtual ICollection<SecuritySituationAttachement> SecuritySituationAttachementModifiedByNavigations { get; set; } = new List<SecuritySituationAttachement>();

    public virtual ICollection<SecuritySituation> SecuritySituationCreatedByNavigations { get; set; } = new List<SecuritySituation>();

    public virtual ICollection<SecuritySituation> SecuritySituationModifiedByNavigations { get; set; } = new List<SecuritySituation>();

    public virtual ICollection<SecuritySituationMonitorLevelDim> SecuritySituationMonitorLevelDimCreatedByNavigations { get; set; } = new List<SecuritySituationMonitorLevelDim>();

    public virtual ICollection<SecuritySituationMonitorLevelDim> SecuritySituationMonitorLevelDimModifiedByNavigations { get; set; } = new List<SecuritySituationMonitorLevelDim>();

    public virtual ICollection<SecuritySituationSourceDim> SecuritySituationSourceDimCreatedByNavigations { get; set; } = new List<SecuritySituationSourceDim>();

    public virtual ICollection<SecuritySituationSourceDim> SecuritySituationSourceDimModifiedByNavigations { get; set; } = new List<SecuritySituationSourceDim>();

    public virtual ICollection<SecuritySituationStatusDim> SecuritySituationStatusDimCreatedByNavigations { get; set; } = new List<SecuritySituationStatusDim>();

    public virtual ICollection<SecuritySituationStatusDim> SecuritySituationStatusDimModifiedByNavigations { get; set; } = new List<SecuritySituationStatusDim>();

    public virtual ICollection<SecuritySituationTypeDim> SecuritySituationTypeDimCreatedByNavigations { get; set; } = new List<SecuritySituationTypeDim>();

    public virtual ICollection<SecuritySituationTypeDim> SecuritySituationTypeDimModifiedByNavigations { get; set; } = new List<SecuritySituationTypeDim>();

    public virtual ICollection<ServiceCall> ServiceCallCreatedByNavigations { get; set; } = new List<ServiceCall>();

    public virtual ICollection<ServiceCall> ServiceCallModifiedByNavigations { get; set; } = new List<ServiceCall>();

    public virtual ICollection<ServiceRequestResponseLogger> ServiceRequestResponseLoggers { get; set; } = new List<ServiceRequestResponseLogger>();

    public virtual ICollection<SmartDispatchingIncidentStatusLog> SmartDispatchingIncidentStatusLogs { get; set; } = new List<SmartDispatchingIncidentStatusLog>();

    public virtual ICollection<SmartDispatchingReturnToOperationRoomLog> SmartDispatchingReturnToOperationRoomLogs { get; set; } = new List<SmartDispatchingReturnToOperationRoomLog>();

    public virtual ICollection<SocialMediaPerson> SocialMediaPeople { get; set; } = new List<SocialMediaPerson>();

    public virtual Source Source { get; set; } = null!;

    public virtual ICollection<State> StateCreatedByNavigations { get; set; } = new List<State>();

    public virtual ICollection<State> StateModifiedByNavigations { get; set; } = new List<State>();

    public virtual ICollection<StateNotificationRole> StateNotificationRoleCreatedByNavigations { get; set; } = new List<StateNotificationRole>();

    public virtual ICollection<StateNotificationRole> StateNotificationRoleModifiedByNavigations { get; set; } = new List<StateNotificationRole>();

    public virtual Subject? Subject { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual ICollection<TrafficCode> TrafficCodeCreatedByNavigations { get; set; } = new List<TrafficCode>();

    public virtual ICollection<TrafficCode> TrafficCodeModifiedByNavigations { get; set; } = new List<TrafficCode>();

    public virtual ICollection<TrafficViolation> TrafficViolationCreatedByNavigations { get; set; } = new List<TrafficViolation>();

    public virtual ICollection<TrafficViolation> TrafficViolationModifiedByNavigations { get; set; } = new List<TrafficViolation>();

    public virtual ICollection<TrafficViolationRejectionReason> TrafficViolationRejectionReasonCreatedByNavigations { get; set; } = new List<TrafficViolationRejectionReason>();

    public virtual ICollection<TrafficViolationRejectionReason> TrafficViolationRejectionReasonModifiedByNavigations { get; set; } = new List<TrafficViolationRejectionReason>();

    public virtual ICollection<TrafficViolationStatusLog> TrafficViolationStatusLogs { get; set; } = new List<TrafficViolationStatusLog>();

    public virtual ICollection<TransferedReportDocument> TransferedReportDocumentCreatedByNavigations { get; set; } = new List<TransferedReportDocument>();

    public virtual ICollection<TransferedReportDocument> TransferedReportDocumentModifiedByNavigations { get; set; } = new List<TransferedReportDocument>();

    public virtual ICollection<TunnelReportBasicDetail> TunnelReportBasicDetails { get; set; } = new List<TunnelReportBasicDetail>();

    public virtual User? User { get; set; }

    public virtual ICollection<VehicleDatum> VehicleData { get; set; } = new List<VehicleDatum>();

    public virtual Victim? Victim { get; set; }

    public virtual ICollection<ViolationAttachement> ViolationAttachementCreatedByNavigations { get; set; } = new List<ViolationAttachement>();

    public virtual ICollection<ViolationAttachement> ViolationAttachementModifiedByNavigations { get; set; } = new List<ViolationAttachement>();

    public virtual ICollection<Violation> ViolationCreatedByNavigations { get; set; } = new List<Violation>();

    public virtual ICollection<Violation> ViolationModifiedByNavigations { get; set; } = new List<Violation>();

    public virtual ICollection<ViolationStepDim> ViolationStepDimCreatedByNavigations { get; set; } = new List<ViolationStepDim>();

    public virtual ICollection<ViolationStepDim> ViolationStepDimModifiedByNavigations { get; set; } = new List<ViolationStepDim>();

    public virtual ICollection<ViolationTypeDim> ViolationTypeDimCreatedByNavigations { get; set; } = new List<ViolationTypeDim>();

    public virtual ICollection<ViolationTypeDim> ViolationTypeDimModifiedByNavigations { get; set; } = new List<ViolationTypeDim>();

    public virtual ICollection<ViolationVehicleDatum> ViolationVehicleData { get; set; } = new List<ViolationVehicleDatum>();

    public virtual ICollection<ViolationsStep> ViolationsSteps { get; set; } = new List<ViolationsStep>();

    public virtual ICollection<Wittness> Wittnesses { get; set; } = new List<Wittness>();
}
