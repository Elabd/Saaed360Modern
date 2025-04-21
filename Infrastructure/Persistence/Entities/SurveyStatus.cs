using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SurveyStatus
{
    public long Id { get; set; }

    public long? Order { get; set; }

    public DateTime? AddedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Ipaddress { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<SurveyDetail> SurveyDetails { get; set; } = new List<SurveyDetail>();

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();
}
