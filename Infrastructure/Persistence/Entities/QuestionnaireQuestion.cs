using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class QuestionnaireQuestion
{
    public long QuestionnaireQuestionId { get; set; }

    public Guid QuestionnaireQuestionGuid { get; set; }

    public long DocumentId { get; set; }

    public Guid DocumentGuid { get; set; }

    public long QuestionId { get; set; }

    public Guid QuestionGuid { get; set; }

    public long SourceId { get; set; }

    public int? OrderBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Document Document { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
