using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SurveyDetail
{
    public long Id { get; set; }

    public long? Order { get; set; }

    public DateTime? AddedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Ipaddress { get; set; }

    public long SurveyAnswerId { get; set; }

    public long SurveyId { get; set; }

    public long SurveyStatusId { get; set; }

    public virtual Survey Survey { get; set; } = null!;

    public virtual SurveyAnswer SurveyAnswer { get; set; } = null!;

    public virtual SurveyStatus SurveyStatus { get; set; } = null!;
}
