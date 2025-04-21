using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SurveySecondaryStatusView
{
    public long? SurveyAnswerId { get; set; }

    public string? SurveyAnswer { get; set; }

    public long SurveyAnswerGroupId { get; set; }

    public string? SurveyAnswerGroupCode { get; set; }

    public DateTime? SurveyDate { get; set; }

    public long EmirateId { get; set; }

    public string EmirateName { get; set; } = null!;
}
