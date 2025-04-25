using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccactivityPersonComment
{
    public long CommentId { get; set; }

    public string? CommentPlain { get; set; }

    public long PersonId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public long ActivityId { get; set; }

    public string? FullName { get; set; }

    public int? CommentCategoryId { get; set; }

    public string? Code { get; set; }
}
