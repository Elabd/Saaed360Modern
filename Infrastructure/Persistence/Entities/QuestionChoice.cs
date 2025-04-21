using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class QuestionChoice
{
    public long QuestionChoiceId { get; set; }

    public Guid QuestionChoiceGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public long QuestionId { get; set; }

    public Guid QuestionGuid { get; set; }

    public string? Text { get; set; }

    public int ScoreValue { get; set; }

    public int? OrderBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<AssessmentResponse> AssessmentResponses { get; set; } = new List<AssessmentResponse>();

    public virtual Question Question { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
