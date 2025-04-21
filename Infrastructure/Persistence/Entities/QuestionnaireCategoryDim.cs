using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class QuestionnaireCategoryDim
{
    public int QuestionnaireCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Questionnaire> Questionnaires { get; set; } = new List<Questionnaire>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
