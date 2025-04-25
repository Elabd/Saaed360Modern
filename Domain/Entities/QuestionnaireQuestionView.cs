using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class QuestionnaireQuestionView
{
    public long QuestionId { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? QuestionCategoryCode { get; set; }

    public string? QuestionCategoryDescription { get; set; }

    public string Text { get; set; } = null!;

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public long QuestionnaireQuestionId { get; set; }

    public long DocumentId { get; set; }

    public int? OrderBy { get; set; }
}
