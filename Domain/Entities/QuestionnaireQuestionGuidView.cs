using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class QuestionnaireQuestionGuidView
{
    public Guid QuestionGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? QuestionCategoryCode { get; set; }

    public string Text { get; set; } = null!;

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public Guid QuestionnaireQuestionGuid { get; set; }

    public Guid DocumentGuid { get; set; }

    public int? OrderBy { get; set; }
}
