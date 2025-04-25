using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class QuestionnaireQuestionContainerGuidView
{
    public Guid QuestionnaireQuestionGuid { get; set; }

    public Guid DocumentGuid { get; set; }

    public Guid QuestionGuid { get; set; }

    public string? SourceName { get; set; }

    public int? OrderBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
