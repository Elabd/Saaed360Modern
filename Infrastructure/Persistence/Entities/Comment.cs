using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Comment
{
    public long CommentId { get; set; }

    public Guid CommentGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int? CommentCategoryId { get; set; }

    public string? CommentName { get; set; }

    public string? CommentFormatted { get; set; }

    public string? CommentPlain { get; set; }

    public int? ImportanceHighLowId { get; set; }

    public int? PriorityHighLowId { get; set; }

    public DateTime? EntryDateTime { get; set; }

    public bool? ActiveIndicator { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ActivityComment> ActivityComments { get; set; } = new List<ActivityComment>();

    public virtual ICollection<ChargeComment> ChargeComments { get; set; } = new List<ChargeComment>();

    public virtual CommentCategoryDim? CommentCategory { get; set; }

    public virtual ICollection<ContactComment> ContactComments { get; set; } = new List<ContactComment>();

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual HighLowDim? ImportanceHighLow { get; set; }

    public virtual ICollection<ItemComment> ItemComments { get; set; } = new List<ItemComment>();

    public virtual ICollection<LocationComment> LocationComments { get; set; } = new List<LocationComment>();

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<OffenseComment> OffenseComments { get; set; } = new List<OffenseComment>();

    public virtual ICollection<OrganizationComment> OrganizationComments { get; set; } = new List<OrganizationComment>();

    public virtual ICollection<PersonCommentNew01> PersonCommentNew01s { get; set; } = new List<PersonCommentNew01>();

    public virtual ICollection<PersonComment> PersonComments { get; set; } = new List<PersonComment>();

    public virtual HighLowDim? PriorityHighLow { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SocialMediaComment> SocialMediaComments { get; set; } = new List<SocialMediaComment>();

    public virtual Source Source { get; set; } = null!;
}
