using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Questionnaire
{
    public long DocumentId { get; set; }

    public int QuestionnaireCategoryId { get; set; }

    public virtual Document Document { get; set; } = null!;

    public virtual QuestionnaireCategoryDim QuestionnaireCategory { get; set; } = null!;
}
