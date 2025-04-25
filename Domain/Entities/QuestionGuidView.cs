using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class QuestionGuidView
{
    public Guid QuestionGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public string? QuestionCategoryCode { get; set; }

    public string Text { get; set; } = null!;

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
