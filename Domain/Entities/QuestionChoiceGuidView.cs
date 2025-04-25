using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class QuestionChoiceGuidView
{
    public Guid QuestionChoiceGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public Guid QuestionGuid { get; set; }

    public string? Text { get; set; }

    public int ScoreValue { get; set; }

    public int? OrderBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
