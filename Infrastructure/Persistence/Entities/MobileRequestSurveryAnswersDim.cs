using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileRequestSurveryAnswersDim
{
    public int MobileRequestSurveyAnswerId { get; set; }

    public int MobileRequestQuestionId { get; set; }

    public int MobileRequestLookupId { get; set; }

    public virtual MobileRequestSurveyQuestion MobileRequestQuestion { get; set; } = null!;

    public virtual ICollection<MobileRequestSurvey> MobileRequestSurveys { get; set; } = new List<MobileRequestSurvey>();
}
