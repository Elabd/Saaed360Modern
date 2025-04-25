using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaInvolvementDim
{
    public int SocialMediaInvolvementId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ActivitySocialMedium> ActivitySocialMedia { get; set; } = new List<ActivitySocialMedium>();

    public virtual ICollection<OrganizationSocialMedium> OrganizationSocialMedia { get; set; } = new List<OrganizationSocialMedium>();

    public virtual ICollection<PersonSocialMedium> PersonSocialMedia { get; set; } = new List<PersonSocialMedium>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SubscriptionSocialMedium> SubscriptionSocialMedia { get; set; } = new List<SubscriptionSocialMedium>();
}
