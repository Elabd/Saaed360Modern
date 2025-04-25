using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SurveyLanguage
{
    public long Id { get; set; }

    public long? Order { get; set; }

    public DateTime? AddedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Ipaddress { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; } = new List<SurveyAnswer>();

    public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; } = new List<SurveyQuestion>();

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();
}
