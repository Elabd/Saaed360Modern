using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SurveyAnswer
{
    public long Id { get; set; }

    public long? Order { get; set; }

    public DateTime? AddedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Ipaddress { get; set; }

    public string? EnName { get; set; }

    public string? ArName { get; set; }

    public long ServiceQuestionId { get; set; }

    public long? SurveyAnswerGroupId { get; set; }

    public string? Image { get; set; }

    public long? SurveyLanguageId { get; set; }

    public long? SurveyParentAnswerId { get; set; }

    public virtual ICollection<SurveyAnswer> InverseSurveyParentAnswer { get; set; } = new List<SurveyAnswer>();

    public virtual SurveyQuestion ServiceQuestion { get; set; } = null!;

    public virtual SurveyAnswerGroup? SurveyAnswerGroup { get; set; }

    public virtual ICollection<SurveyDetail> SurveyDetails { get; set; } = new List<SurveyDetail>();

    public virtual SurveyLanguage? SurveyLanguage { get; set; }

    public virtual SurveyAnswer? SurveyParentAnswer { get; set; }

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();
}
