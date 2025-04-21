using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Questionnaire
{
    public long DocumentId { get; set; }

    public int QuestionnaireCategoryId { get; set; }

    public virtual Document Document { get; set; } = null!;

    public virtual QuestionnaireCategoryDim QuestionnaireCategory { get; set; } = null!;
}
