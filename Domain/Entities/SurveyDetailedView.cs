using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SurveyDetailedView
{
    public string? ReportNumber { get; set; }

    public string? PlateNumber { get; set; }

    public string? Customer { get; set; }

    public long EmirateId { get; set; }

    public string Emirate { get; set; } = null!;

    public long SurveyMessegeId { get; set; }

    public long? SurveyAnswerId { get; set; }

    public string? SurveyAnswer { get; set; }

    public long SurveyDetailsAnswerId { get; set; }

    public string? SurveyDetailAnswer { get; set; }

    public long? SurveyAnswerGroupId { get; set; }

    public DateTime? SurveyDate { get; set; }

    public string? UnsatisfiedReason { get; set; }
}
