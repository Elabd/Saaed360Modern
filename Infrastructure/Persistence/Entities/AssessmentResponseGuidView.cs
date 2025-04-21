using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AssessmentResponseGuidView
{
    public Guid AssessmentResponseGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public Guid ActivityGuid { get; set; }

    public Guid QuestionGuid { get; set; }

    public Guid QuestionChoiceGuid { get; set; }

    public string? Text { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
