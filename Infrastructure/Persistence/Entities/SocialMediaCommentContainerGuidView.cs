using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SocialMediaCommentContainerGuidView
{
    public Guid SocialMediaCommentGuid { get; set; }

    public string Description { get; set; } = null!;

    public Guid SocialMediaGuid { get; set; }

    public string? SourceName { get; set; }

    public string? CommentInvolvementCode { get; set; }

    public Guid CommentGuid { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
