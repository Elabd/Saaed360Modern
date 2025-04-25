using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Location
{
    public long LocationId { get; set; }

    public Guid LocationGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int LocationCategoryId { get; set; }

    public string? LocationName { get; set; }

    public string? Description { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<ActivityItemStatusLocation> ActivityItemStatusLocations { get; set; } = new List<ActivityItemStatusLocation>();

    public virtual ICollection<ActivityLocation> ActivityLocations { get; set; } = new List<ActivityLocation>();

    public virtual ICollection<Aircraft> Aircraft { get; set; } = new List<Aircraft>();

    public virtual ICollection<ItemLocation> ItemLocations { get; set; } = new List<ItemLocation>();

    public virtual ICollection<LocationArea> LocationAreas { get; set; } = new List<LocationArea>();

    public virtual LocationCategoryDim LocationCategory { get; set; } = null!;

    public virtual ICollection<LocationComment> LocationComments { get; set; } = new List<LocationComment>();

    public virtual ICollection<LocationContact> LocationContacts { get; set; } = new List<LocationContact>();

    public virtual ICollection<LocationDocument> LocationDocuments { get; set; } = new List<LocationDocument>();

    public virtual ICollection<LocationImage> LocationImages { get; set; } = new List<LocationImage>();

    public virtual ICollection<MissingPerson> MissingPersonFoundLocations { get; set; } = new List<MissingPerson>();

    public virtual ICollection<MissingPerson> MissingPersonLastSeenLocations { get; set; } = new List<MissingPerson>();

    public virtual ICollection<OrganizationLocation> OrganizationLocations { get; set; } = new List<OrganizationLocation>();

    public virtual ICollection<PersonLocation> PersonLocations { get; set; } = new List<PersonLocation>();

    public virtual ICollection<Realestate> Realestates { get; set; } = new List<Realestate>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SocialMediaLocation> SocialMediaLocations { get; set; } = new List<SocialMediaLocation>();

    public virtual Source Source { get; set; } = null!;

    public virtual ICollection<SubjectOrganization> SubjectOrganizations { get; set; } = new List<SubjectOrganization>();

    public virtual ICollection<SubscriptionLocation> SubscriptionLocations { get; set; } = new List<SubscriptionLocation>();
}
