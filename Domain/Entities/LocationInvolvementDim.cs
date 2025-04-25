using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationInvolvementDim
{
    public int LocationInvolvementId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ActivityLocation> ActivityLocations { get; set; } = new List<ActivityLocation>();

    public virtual ICollection<ItemLocation> ItemLocations { get; set; } = new List<ItemLocation>();

    public virtual ICollection<OrganizationLocation> OrganizationLocations { get; set; } = new List<OrganizationLocation>();

    public virtual ICollection<PersonLocation> PersonLocations { get; set; } = new List<PersonLocation>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SocialMediaLocation> SocialMediaLocations { get; set; } = new List<SocialMediaLocation>();

    public virtual ICollection<SubscriptionLocation> SubscriptionLocations { get; set; } = new List<SubscriptionLocation>();
}
