using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileRequestSurveyQuestion
{
    public int MobileRequestSurveyQuestionId { get; set; }

    public string QuestionDescEn { get; set; } = null!;

    public string QuestionDescAr { get; set; } = null!;

    public virtual ICollection<MobileRequestSurveryAnswersDim> MobileRequestSurveryAnswersDims { get; set; } = new List<MobileRequestSurveryAnswersDim>();
}
