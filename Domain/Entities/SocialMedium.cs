using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMedium
{
    public long SocialMediaId { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int SocialMediaCategoryId { get; set; }

    public string? Account { get; set; }

    public string Uri { get; set; } = null!;

    public string? Information { get; set; }

    public string? Title { get; set; }

    public string? RawData { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ActivitySocialMedium> ActivitySocialMedia { get; set; } = new List<ActivitySocialMedium>();

    public virtual ICollection<OrganizationSocialMedium> OrganizationSocialMedia { get; set; } = new List<OrganizationSocialMedium>();

    public virtual ICollection<PersonSocialMedium> PersonSocialMedia { get; set; } = new List<PersonSocialMedium>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SocialMediaAuthorization> SocialMediaAuthorizations { get; set; } = new List<SocialMediaAuthorization>();

    public virtual SocialMediaCategoryDim SocialMediaCategory { get; set; } = null!;

    public virtual ICollection<SocialMediaComment> SocialMediaComments { get; set; } = new List<SocialMediaComment>();

    public virtual ICollection<SocialMediaLocation> SocialMediaLocations { get; set; } = new List<SocialMediaLocation>();

    public virtual ICollection<SocialMediaPerson> SocialMediaPeople { get; set; } = new List<SocialMediaPerson>();

    public virtual Source Source { get; set; } = null!;

    public virtual ICollection<SubscriptionSocialMedium> SubscriptionSocialMedia { get; set; } = new List<SubscriptionSocialMedium>();
}
