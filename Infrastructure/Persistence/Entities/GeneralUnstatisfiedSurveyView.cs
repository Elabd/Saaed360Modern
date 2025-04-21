using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GeneralUnstatisfiedSurveyView
{
    public DateTime? SurveyDate { get; set; }

    public long EmirateId { get; set; }

    public string Emirate { get; set; } = null!;

    public long SurveyAnswerId { get; set; }
}
