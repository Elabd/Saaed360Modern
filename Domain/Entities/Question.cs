using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Question
{
    public long QuestionId { get; set; }

    public Guid QuestionGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int QuestionCategoryId { get; set; }

    public string Text { get; set; } = null!;

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<AssessmentResponse> AssessmentResponses { get; set; } = new List<AssessmentResponse>();

    public virtual QuestionCategoryDim QuestionCategory { get; set; } = null!;

    public virtual ICollection<QuestionChoice> QuestionChoices { get; set; } = new List<QuestionChoice>();

    public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; } = new List<QuestionnaireQuestion>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
