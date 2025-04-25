using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Source
{
    public long SourceId { get; set; }

    public Guid SourceGuid { get; set; }

    public int SourceCategoryId { get; set; }

    public int SourcePolicyId { get; set; }

    public string? SourceName { get; set; }

    public string? Description { get; set; }

    public int? RetentionPeriodDays { get; set; }

    public bool? RetentionPeriodEnforcedIndicator { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool IsDetailRequired { get; set; }

    public virtual ICollection<ActivityArea> ActivityAreas { get; set; } = new List<ActivityArea>();

    public virtual ICollection<ActivityComment> ActivityComments { get; set; } = new List<ActivityComment>();

    public virtual ICollection<ActivityContact> ActivityContacts { get; set; } = new List<ActivityContact>();

    public virtual ICollection<ActivityDocument> ActivityDocuments { get; set; } = new List<ActivityDocument>();

    public virtual ICollection<ActivityImage> ActivityImages { get; set; } = new List<ActivityImage>();

    public virtual ICollection<ActivityLocation> ActivityLocations { get; set; } = new List<ActivityLocation>();

    public virtual ICollection<ActivityOrganization> ActivityOrganizations { get; set; } = new List<ActivityOrganization>();

    public virtual ICollection<ActivityPerson> ActivityPeople { get; set; } = new List<ActivityPerson>();

    public virtual ICollection<ActivitySocialMedium> ActivitySocialMedia { get; set; } = new List<ActivitySocialMedium>();

    public virtual ICollection<ActivitySubscription> ActivitySubscriptions { get; set; } = new List<ActivitySubscription>();

    public virtual ICollection<AreaAssociation> AreaAssociations { get; set; } = new List<AreaAssociation>();

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<ArrestCharge> ArrestCharges { get; set; } = new List<ArrestCharge>();

    public virtual ICollection<ArrestWarrant> ArrestWarrants { get; set; } = new List<ArrestWarrant>();

    public virtual ICollection<AssessmentResponse> AssessmentResponses { get; set; } = new List<AssessmentResponse>();

    public virtual ICollection<AuditDetail> AuditDetails { get; set; } = new List<AuditDetail>();

    public virtual ICollection<CaseCharge> CaseCharges { get; set; } = new List<CaseCharge>();

    public virtual ICollection<CaseExhibitEvidence> CaseExhibitEvidences { get; set; } = new List<CaseExhibitEvidence>();

    public virtual ICollection<ChargeComment> ChargeComments { get; set; } = new List<ChargeComment>();

    public virtual ICollection<ChargeDisposition> ChargeDispositions { get; set; } = new List<ChargeDisposition>();

    public virtual ICollection<Charge> Charges { get; set; } = new List<Charge>();

    public virtual ICollection<CitationViolation> CitationViolations { get; set; } = new List<CitationViolation>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<ContactComment> ContactComments { get; set; } = new List<ContactComment>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<CourtOrderWarrant> CourtOrderWarrants { get; set; } = new List<CourtOrderWarrant>();

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<EducationSchedule> EducationSchedules { get; set; } = new List<EducationSchedule>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<IncidentFactor> IncidentFactors { get; set; } = new List<IncidentFactor>();

    public virtual ICollection<IncidentStatute> IncidentStatutes { get; set; } = new List<IncidentStatute>();

    public virtual ICollection<ItemAlias> ItemAliases { get; set; } = new List<ItemAlias>();

    public virtual ICollection<ItemComment> ItemComments { get; set; } = new List<ItemComment>();

    public virtual ICollection<ItemDocument> ItemDocuments { get; set; } = new List<ItemDocument>();

    public virtual ICollection<ItemIdentifier> ItemIdentifiers { get; set; } = new List<ItemIdentifier>();

    public virtual ICollection<ItemImage> ItemImages { get; set; } = new List<ItemImage>();

    public virtual ICollection<ItemLocation> ItemLocations { get; set; } = new List<ItemLocation>();

    public virtual ICollection<ItemRegistration> ItemRegistrations { get; set; } = new List<ItemRegistration>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<JewelryStone> JewelryStones { get; set; } = new List<JewelryStone>();

    public virtual ICollection<LocationArea> LocationAreas { get; set; } = new List<LocationArea>();

    public virtual ICollection<LocationComment> LocationComments { get; set; } = new List<LocationComment>();

    public virtual ICollection<LocationContact> LocationContacts { get; set; } = new List<LocationContact>();

    public virtual ICollection<LocationDocument> LocationDocuments { get; set; } = new List<LocationDocument>();

    public virtual ICollection<LocationImage> LocationImages { get; set; } = new List<LocationImage>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<OffenseChargeAssociation> OffenseChargeAssociations { get; set; } = new List<OffenseChargeAssociation>();

    public virtual ICollection<OffenseCitationAssociation> OffenseCitationAssociations { get; set; } = new List<OffenseCitationAssociation>();

    public virtual ICollection<OffenseComment> OffenseComments { get; set; } = new List<OffenseComment>();

    public virtual ICollection<OffenseIncidentAssociation> OffenseIncidentAssociations { get; set; } = new List<OffenseIncidentAssociation>();

    public virtual ICollection<Offense> Offenses { get; set; } = new List<Offense>();

    public virtual ICollection<OrganizationAssociation> OrganizationAssociations { get; set; } = new List<OrganizationAssociation>();

    public virtual ICollection<OrganizationComment> OrganizationComments { get; set; } = new List<OrganizationComment>();

    public virtual ICollection<OrganizationContact> OrganizationContacts { get; set; } = new List<OrganizationContact>();

    public virtual ICollection<OrganizationDocument> OrganizationDocuments { get; set; } = new List<OrganizationDocument>();

    public virtual ICollection<OrganizationImage> OrganizationImages { get; set; } = new List<OrganizationImage>();

    public virtual ICollection<OrganizationItem> OrganizationItems { get; set; } = new List<OrganizationItem>();

    public virtual ICollection<OrganizationLocation> OrganizationLocations { get; set; } = new List<OrganizationLocation>();

    public virtual ICollection<OrganizationPerson> OrganizationPeople { get; set; } = new List<OrganizationPerson>();

    public virtual ICollection<OrganizationSocialMedium> OrganizationSocialMedia { get; set; } = new List<OrganizationSocialMedium>();

    public virtual ICollection<OrganizationUnitLog> OrganizationUnitLogs { get; set; } = new List<OrganizationUnitLog>();

    public virtual ICollection<OrganizationUnitPersonnel> OrganizationUnitPersonnel { get; set; } = new List<OrganizationUnitPersonnel>();

    public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; } = new List<OrganizationUnit>();

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();

    public virtual ICollection<Person> People { get; set; } = new List<Person>();

    public virtual ICollection<PersonAffiliation> PersonAffiliations { get; set; } = new List<PersonAffiliation>();

    public virtual ICollection<PersonAlias> PersonAliases { get; set; } = new List<PersonAlias>();

    public virtual ICollection<PersonCitizenship> PersonCitizenships { get; set; } = new List<PersonCitizenship>();

    public virtual ICollection<PersonClothing> PersonClothings { get; set; } = new List<PersonClothing>();

    public virtual ICollection<PersonCommentNew01> PersonCommentNew01s { get; set; } = new List<PersonCommentNew01>();

    public virtual ICollection<PersonComment> PersonComments { get; set; } = new List<PersonComment>();

    public virtual ICollection<PersonContact> PersonContacts { get; set; } = new List<PersonContact>();

    public virtual ICollection<PersonDocument> PersonDocuments { get; set; } = new List<PersonDocument>();

    public virtual ICollection<PersonDriverLicense> PersonDriverLicenses { get; set; } = new List<PersonDriverLicense>();

    public virtual ICollection<PersonEducation> PersonEducations { get; set; } = new List<PersonEducation>();

    public virtual ICollection<PersonEmployment> PersonEmployments { get; set; } = new List<PersonEmployment>();

    public virtual ICollection<PersonFingerprintSet> PersonFingerprintSets { get; set; } = new List<PersonFingerprintSet>();

    public virtual ICollection<PersonImage> PersonImages { get; set; } = new List<PersonImage>();

    public virtual ICollection<PersonInjury> PersonInjuries { get; set; } = new List<PersonInjury>();

    public virtual ICollection<PersonIntoxication> PersonIntoxications { get; set; } = new List<PersonIntoxication>();

    public virtual ICollection<PersonItem> PersonItems { get; set; } = new List<PersonItem>();

    public virtual ICollection<PersonLanguage> PersonLanguages { get; set; } = new List<PersonLanguage>();

    public virtual ICollection<PersonLocation> PersonLocations { get; set; } = new List<PersonLocation>();

    public virtual ICollection<PersonMedicalCondition> PersonMedicalConditions { get; set; } = new List<PersonMedicalCondition>();

    public virtual ICollection<PersonMilitarySummary> PersonMilitarySummaries { get; set; } = new List<PersonMilitarySummary>();

    public virtual ICollection<PersonOtherIdentification> PersonOtherIdentifications { get; set; } = new List<PersonOtherIdentification>();

    public virtual ICollection<PersonPhysicalDetail> PersonPhysicalDetails { get; set; } = new List<PersonPhysicalDetail>();

    public virtual ICollection<PersonPhysicalFeature> PersonPhysicalFeatures { get; set; } = new List<PersonPhysicalFeature>();

    public virtual ICollection<PersonRelationship> PersonRelationships { get; set; } = new List<PersonRelationship>();

    public virtual ICollection<PersonSocialMedium> PersonSocialMedia { get; set; } = new List<PersonSocialMedium>();

    public virtual ICollection<PersonTooth> PersonTeeth { get; set; } = new List<PersonTooth>();

    public virtual ICollection<PersonVitalStatistic> PersonVitalStatistics { get; set; } = new List<PersonVitalStatistic>();

    public virtual ICollection<QuestionChoice> QuestionChoices { get; set; } = new List<QuestionChoice>();

    public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; } = new List<QuestionnaireQuestion>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SearchDetail> SearchDetails { get; set; } = new List<SearchDetail>();

    public virtual ICollection<SearchResponse> SearchResponses { get; set; } = new List<SearchResponse>();

    public virtual ICollection<Search> Searches { get; set; } = new List<Search>();

    public virtual ICollection<SocialMedium> SocialMedia { get; set; } = new List<SocialMedium>();

    public virtual ICollection<SocialMediaAuthorization> SocialMediaAuthorizations { get; set; } = new List<SocialMediaAuthorization>();

    public virtual ICollection<SocialMediaComment> SocialMediaComments { get; set; } = new List<SocialMediaComment>();

    public virtual ICollection<SocialMediaLocation> SocialMediaLocations { get; set; } = new List<SocialMediaLocation>();

    public virtual ICollection<SocialMediaPerson> SocialMediaPeople { get; set; } = new List<SocialMediaPerson>();

    public virtual SourceCategoryDim SourceCategory { get; set; } = null!;

    public virtual ICollection<SourceDetail> SourceDetails { get; set; } = new List<SourceDetail>();

    public virtual SourcePolicyDim SourcePolicy { get; set; } = null!;

    public virtual ICollection<SubjectRegistration> SubjectRegistrations { get; set; } = new List<SubjectRegistration>();

    public virtual ICollection<SubscriptionLocation> SubscriptionLocations { get; set; } = new List<SubscriptionLocation>();

    public virtual ICollection<SubscriptionPolygon> SubscriptionPolygons { get; set; } = new List<SubscriptionPolygon>();

    public virtual ICollection<SubscriptionSocialMedium> SubscriptionSocialMedia { get; set; } = new List<SubscriptionSocialMedium>();

    public virtual ICollection<SubscriptionSubdivision> SubscriptionSubdivisions { get; set; } = new List<SubscriptionSubdivision>();

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();

    public virtual ICollection<WarrantAppearanceBail> WarrantAppearanceBails { get; set; } = new List<WarrantAppearanceBail>();
}
