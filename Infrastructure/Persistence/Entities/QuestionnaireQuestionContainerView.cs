using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class QuestionnaireQuestionContainerView
{
    public long QuestionnaireQuestionId { get; set; }

    public long DocumentId { get; set; }

    public long QuestionId { get; set; }

    public string? SourceName { get; set; }

    public int? OrderBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
