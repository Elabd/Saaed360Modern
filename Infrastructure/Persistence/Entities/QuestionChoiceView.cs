using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class QuestionChoiceView
{
    public long QuestionChoiceId { get; set; }

    public string? OriginalIdent { get; set; }

    public long QuestionId { get; set; }

    public string? Text { get; set; }

    public int ScoreValue { get; set; }

    public int? OrderBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
