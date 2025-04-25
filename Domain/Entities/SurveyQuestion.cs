using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SurveyQuestion
{
    public long Id { get; set; }

    public long? Order { get; set; }

    public DateTime? AddedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Ipaddress { get; set; }

    public string? ArName { get; set; }

    public string? EnName { get; set; }

    public long SurveyQuestionTypeId { get; set; }

    public long? SurveyAnswerGroupId { get; set; }

    public long? SurveyLanguageId { get; set; }

    public virtual SurveyAnswerGroup? SurveyAnswerGroup { get; set; }

    public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; } = new List<SurveyAnswer>();

    public virtual SurveyLanguage? SurveyLanguage { get; set; }

    public virtual SurveyQuestionType SurveyQuestionType { get; set; } = null!;
}
