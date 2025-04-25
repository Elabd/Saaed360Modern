using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileSurveyLookupDim
{
    public int SurveyAnswerLookupId { get; set; }

    public string AnswerDescEn { get; set; } = null!;

    public string AnswerDescAr { get; set; } = null!;
}
