using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SurveyMessege
{
    public long Id { get; set; }

    public string? ReporNumber { get; set; }

    public string? MobileNumber { get; set; }

    public DateTime? TimeStamp { get; set; }

    public bool? Sent { get; set; }

    public string? PlateNumber { get; set; }

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();
}
