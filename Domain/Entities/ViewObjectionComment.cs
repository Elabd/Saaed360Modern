using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewObjectionComment
{
    public string CommentText { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public long ObjectionId { get; set; }

    public long PersonId { get; set; }

    public string PersonName { get; set; } = null!;
}
