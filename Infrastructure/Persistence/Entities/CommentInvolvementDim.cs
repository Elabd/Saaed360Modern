using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CommentInvolvementDim
{
    public int CommentInvolvementId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ActivityComment> ActivityComments { get; set; } = new List<ActivityComment>();

    public virtual ICollection<ContactComment> ContactComments { get; set; } = new List<ContactComment>();

    public virtual ICollection<ItemComment> ItemComments { get; set; } = new List<ItemComment>();

    public virtual ICollection<LocationComment> LocationComments { get; set; } = new List<LocationComment>();

    public virtual ICollection<OrganizationComment> OrganizationComments { get; set; } = new List<OrganizationComment>();

    public virtual ICollection<PersonCommentNew01> PersonCommentNew01s { get; set; } = new List<PersonCommentNew01>();

    public virtual ICollection<PersonComment> PersonComments { get; set; } = new List<PersonComment>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SocialMediaComment> SocialMediaComments { get; set; } = new List<SocialMediaComment>();
}
