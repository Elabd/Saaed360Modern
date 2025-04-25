using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Organization
{
    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int? OrganizationCategoryId { get; set; }

    public int? OrganizationStatusId { get; set; }

    public string? Name { get; set; }

    public string? DoingBusinessAs { get; set; }

    public string? Description { get; set; }

    public string? AbbreviationText { get; set; }

    public string? Imonumber { get; set; }

    public DateTime? EstablishedDateTime { get; set; }

    public DateTime? TerminationDateTime { get; set; }

    public bool? IncorporatedIndicator { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? Image { get; set; }

    public bool? IsTs { get; set; }

    public virtual ICollection<ActivityConvertToStationArc> ActivityConvertToStationArcs { get; set; } = new List<ActivityConvertToStationArc>();

    public virtual ICollection<ActivityConvertToStation> ActivityConvertToStations { get; set; } = new List<ActivityConvertToStation>();

    public virtual ICollection<ActivityOrganization> ActivityOrganizations { get; set; } = new List<ActivityOrganization>();

    public virtual ICollection<ActivityTransaction> ActivityTransactions { get; set; } = new List<ActivityTransaction>();

    public virtual Agency? Agency { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<CaseExhibit> CaseExhibits { get; set; } = new List<CaseExhibit>();

    public virtual Court? Court { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Facility? Facility { get; set; }

    public virtual ICollection<GeoLeodim> GeoLeodims { get; set; } = new List<GeoLeodim>();

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<Objection> Objections { get; set; } = new List<Objection>();

    public virtual ICollection<OrganizationAssociation> OrganizationAssociationOrganizationRelateds { get; set; } = new List<OrganizationAssociation>();

    public virtual ICollection<OrganizationAssociation> OrganizationAssociationOrganizations { get; set; } = new List<OrganizationAssociation>();

    public virtual OrganizationCategoryDim? OrganizationCategory { get; set; }

    public virtual ICollection<OrganizationComment> OrganizationComments { get; set; } = new List<OrganizationComment>();

    public virtual ICollection<OrganizationContact> OrganizationContacts { get; set; } = new List<OrganizationContact>();

    public virtual ICollection<OrganizationDocument> OrganizationDocuments { get; set; } = new List<OrganizationDocument>();

    public virtual ICollection<OrganizationImage> OrganizationImages { get; set; } = new List<OrganizationImage>();

    public virtual ICollection<OrganizationItem> OrganizationItems { get; set; } = new List<OrganizationItem>();

    public virtual ICollection<OrganizationLocation> OrganizationLocations { get; set; } = new List<OrganizationLocation>();

    public virtual ICollection<OrganizationPerson> OrganizationPeople { get; set; } = new List<OrganizationPerson>();

    public virtual ICollection<OrganizationReason> OrganizationReasons { get; set; } = new List<OrganizationReason>();

    public virtual ICollection<OrganizationRole> OrganizationRoles { get; set; } = new List<OrganizationRole>();

    public virtual ICollection<OrganizationSocialMedium> OrganizationSocialMedia { get; set; } = new List<OrganizationSocialMedium>();

    public virtual OrganizationStatusDim? OrganizationStatus { get; set; }

    public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; } = new List<OrganizationUnit>();

    public virtual ICollection<PersonAffiliation> PersonAffiliations { get; set; } = new List<PersonAffiliation>();

    public virtual ICollection<PersonEducation> PersonEducations { get; set; } = new List<PersonEducation>();

    public virtual ICollection<PersonEmployment> PersonEmployments { get; set; } = new List<PersonEmployment>();

    public virtual Provider? Provider { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<ServiceCallIncidentTypeDim> ServiceCallIncidentTypeDims { get; set; } = new List<ServiceCallIncidentTypeDim>();

    public virtual Source Source { get; set; } = null!;

    public virtual SubjectOrganization? SubjectOrganization { get; set; }

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
