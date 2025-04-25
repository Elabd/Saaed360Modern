using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Survey
{
    public long Id { get; set; }

    public long? Order { get; set; }

    public DateTime? AddedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Ipaddress { get; set; }

    public string? ReportNumber { get; set; }

    public string? MobileNumber { get; set; }

    public string? Comment { get; set; }

    public long SurveyLanguageId { get; set; }

    public long SurveyStatusId { get; set; }

    public long? SurveyAnswerId { get; set; }

    public long? SurveyMessageId { get; set; }

    public virtual SurveyAnswer? SurveyAnswer { get; set; }

    public virtual ICollection<SurveyDetail> SurveyDetails { get; set; } = new List<SurveyDetail>();

    public virtual SurveyLanguage SurveyLanguage { get; set; } = null!;

    public virtual SurveyMessege? SurveyMessage { get; set; }

    public virtual SurveyStatus SurveyStatus { get; set; } = null!;
}
