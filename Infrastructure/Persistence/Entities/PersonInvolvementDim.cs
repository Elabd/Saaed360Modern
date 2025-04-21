using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonInvolvementDim
{
    public int PersonInvolvementId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ActivityPerson> ActivityPeople { get; set; } = new List<ActivityPerson>();

    public virtual ICollection<OrganizationPerson> OrganizationPeople { get; set; } = new List<OrganizationPerson>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SocialMediaPerson> SocialMediaPeople { get; set; } = new List<SocialMediaPerson>();
}
