using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CommentCategoryDim
{
    public int CommentCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
