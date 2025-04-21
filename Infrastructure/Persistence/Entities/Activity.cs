using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Activity
{
    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int ActivityCategoryId { get; set; }

    public int ActivityReasonId { get; set; }

    public int StatusId { get; set; }

    public string? ActivityName { get; set; }

    public string? ActivityDescription { get; set; }

    public DateTime? ActivityStartDate { get; set; }

    public DateTime? ActivityEndDate { get; set; }

    public DateTime? ActivityDueDate { get; set; }

    public DateTime? ActivityExpirationDate { get; set; }

    public bool? IsCompleted { get; set; }

    public DateTime? ActivityDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public Guid? WorkFlowGuid { get; set; }

    public bool? IsAutoDispatch { get; set; }

    public virtual ICollection<ActivityArea> ActivityAreas { get; set; } = new List<ActivityArea>();

    public virtual ICollection<ActivityAssociation> ActivityAssociationActivities { get; set; } = new List<ActivityAssociation>();

    public virtual ICollection<ActivityAssociation> ActivityAssociationRelatedActivities { get; set; } = new List<ActivityAssociation>();

    public virtual ActivityCategoryDim ActivityCategory { get; set; } = null!;

    public virtual ICollection<ActivityComment> ActivityComments { get; set; } = new List<ActivityComment>();

    public virtual ICollection<ActivityContact> ActivityContacts { get; set; } = new List<ActivityContact>();

    public virtual ICollection<ActivityConvertToStationArc> ActivityConvertToStationArcs { get; set; } = new List<ActivityConvertToStationArc>();

    public virtual ICollection<ActivityConvertToStation> ActivityConvertToStations { get; set; } = new List<ActivityConvertToStation>();

    public virtual ICollection<ActivityDocument> ActivityDocuments { get; set; } = new List<ActivityDocument>();

    public virtual ICollection<ActivityImage> ActivityImages { get; set; } = new List<ActivityImage>();

    public virtual ICollection<ActivityItem> ActivityItems { get; set; } = new List<ActivityItem>();

    public virtual ICollection<ActivityLocation> ActivityLocations { get; set; } = new List<ActivityLocation>();

    public virtual ICollection<ActivityLog> ActivityLogs { get; set; } = new List<ActivityLog>();

    public virtual ICollection<ActivityOrganization> ActivityOrganizations { get; set; } = new List<ActivityOrganization>();

    public virtual ICollection<ActivityPerson> ActivityPeople { get; set; } = new List<ActivityPerson>();

    public virtual ActivityReasonDim ActivityReason { get; set; } = null!;

    public virtual ICollection<ActivityReport> ActivityReports { get; set; } = new List<ActivityReport>();

    public virtual ICollection<ActivitySocialMedium> ActivitySocialMedia { get; set; } = new List<ActivitySocialMedium>();

    public virtual ICollection<ActivitySubscription> ActivitySubscriptions { get; set; } = new List<ActivitySubscription>();

    public virtual ICollection<ActivityTask> ActivityTasks { get; set; } = new List<ActivityTask>();

    public virtual ICollection<ActivityTransaction> ActivityTransactions { get; set; } = new List<ActivityTransaction>();

    public virtual Alert? Alert { get; set; }

    public virtual Arrest? Arrest { get; set; }

    public virtual ICollection<ArrestCharge> ArrestCharges { get; set; } = new List<ArrestCharge>();

    public virtual ICollection<ArrestWarrant> ArrestWarrants { get; set; } = new List<ArrestWarrant>();

    public virtual Assessment? Assessment { get; set; }

    public virtual ICollection<AssessmentResponse> AssessmentResponses { get; set; } = new List<AssessmentResponse>();

    public virtual Audit? Audit { get; set; }

    public virtual ICollection<AuditDetail> AuditDetails { get; set; } = new List<AuditDetail>();

    public virtual Bail? Bail { get; set; }

    public virtual Bolo? Bolo { get; set; }

    public virtual Bond? Bond { get; set; }

    public virtual Booking? Booking { get; set; }

    public virtual Case? Case { get; set; }

    public virtual ICollection<CaseCharge> CaseCharges { get; set; } = new List<CaseCharge>();

    public virtual CaseExhibit? CaseExhibit { get; set; }

    public virtual ICollection<CaseExhibitEvidence> CaseExhibitEvidences { get; set; } = new List<CaseExhibitEvidence>();

    public virtual ICollection<ChargeDisposition> ChargeDispositions { get; set; } = new List<ChargeDisposition>();

    public virtual Citation? Citation { get; set; }

    public virtual ICollection<CitationViolation> CitationViolations { get; set; } = new List<CitationViolation>();

    public virtual CommunityService? CommunityService { get; set; }

    public virtual Condition? Condition { get; set; }

    public virtual Correction? Correction { get; set; }

    public virtual Counseling? Counseling { get; set; }

    public virtual CourtAction? CourtAction { get; set; }

    public virtual CourtEvent? CourtEvent { get; set; }

    public virtual CourtOrder? CourtOrder { get; set; }

    public virtual ICollection<CourtOrderWarrant> CourtOrderWarrants { get; set; } = new List<CourtOrderWarrant>();

    public virtual CustodyTransfer? CustodyTransfer { get; set; }

    public virtual DisciplinaryAction? DisciplinaryAction { get; set; }

    public virtual Disposition? Disposition { get; set; }

    public virtual Dissemination? Dissemination { get; set; }

    public virtual Docket? Docket { get; set; }

    public virtual DrivingIncident? DrivingIncident { get; set; }

    public virtual ICollection<IcccincidentRequest> IcccincidentRequests { get; set; } = new List<IcccincidentRequest>();

    public virtual IdentityTheftIncident? IdentityTheftIncident { get; set; }

    public virtual Incident? Incident { get; set; }

    public virtual ICollection<IncidentFactor> IncidentFactors { get; set; } = new List<IncidentFactor>();

    public virtual ICollection<IncidentStatute> IncidentStatutes { get; set; } = new List<IncidentStatute>();

    public virtual LicensePlateLocation? LicensePlateLocation { get; set; }

    public virtual ICollection<MobileRequest> MobileRequests { get; set; } = new List<MobileRequest>();

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<OffenseCitationAssociation> OffenseCitationAssociations { get; set; } = new List<OffenseCitationAssociation>();

    public virtual ICollection<OffenseComment> OffenseComments { get; set; } = new List<OffenseComment>();

    public virtual ICollection<OffenseIncidentAssociation> OffenseIncidentAssociations { get; set; } = new List<OffenseIncidentAssociation>();

    public virtual Parole? Parole { get; set; }

    public virtual Probation? Probation { get; set; }

    public virtual ProgramParticipation? ProgramParticipation { get; set; }

    public virtual RegisterofAction? RegisterofAction { get; set; }

    public virtual Release? Release { get; set; }

    public virtual Request? Request { get; set; }

    public virtual ICollection<RequestCheck> RequestChecks { get; set; } = new List<RequestCheck>();

    public virtual ICollection<RequestOffense> RequestOffenses { get; set; } = new List<RequestOffense>();

    public virtual ICollection<RequestService> RequestServices { get; set; } = new List<RequestService>();

    public virtual ICollection<RequestViolation> RequestViolations { get; set; } = new List<RequestViolation>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Search? Search { get; set; }

    public virtual ICollection<SearchDetail> SearchDetails { get; set; } = new List<SearchDetail>();

    public virtual SearchResponse? SearchResponse { get; set; }

    public virtual Sentence? Sentence { get; set; }

    public virtual ServiceCall? ServiceCall { get; set; }

    public virtual SourceDetail Source { get; set; } = null!;

    public virtual StatusDim Status { get; set; } = null!;

    public virtual ICollection<SubjectRegistration> SubjectRegistrations { get; set; } = new List<SubjectRegistration>();

    public virtual Supervision? Supervision { get; set; }

    public virtual TipLead? TipLead { get; set; }

    public virtual ICollection<TipLeadOffense> TipLeadOffenses { get; set; } = new List<TipLeadOffense>();

    public virtual ICollection<Violation> Violations { get; set; } = new List<Violation>();

    public virtual Warrant? Warrant { get; set; }

    public virtual ICollection<WarrantAppearanceBail> WarrantAppearanceBails { get; set; } = new List<WarrantAppearanceBail>();
}
