using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationComment
{
    public long OrganizationCommentId { get; set; }

    public Guid OrganizationCommentGuid { get; set; }

    public string OrganizationCommentDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

    public long CommentId { get; set; }

    public Guid CommentGuid { get; set; }

    public int CommentInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Comment Comment { get; set; } = null!;

    public virtual CommentInvolvementDim CommentInvolvement { get; set; } = null!;

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual ICollection<SubjectOrganization> SubjectOrganizations { get; set; } = new List<SubjectOrganization>();
}
