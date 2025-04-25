using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AssessmentResponse
{
    public long AssessmentResponseId { get; set; }

    public Guid AssessmentResponseGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long QuestionId { get; set; }

    public Guid QuestionGuid { get; set; }

    public long? QuestionChoiceId { get; set; }

    public Guid QuestionChoiceGuid { get; set; }

    public string? Text { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;

    public virtual QuestionChoice? QuestionChoice { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
