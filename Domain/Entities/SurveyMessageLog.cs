using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SurveyMessageLog
{
    public long Id { get; set; }

    public string? MobileNumber { get; set; }

    public string? ReportNumber { get; set; }

    public string? Url { get; set; }

    public bool? Sent { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? Error { get; set; }
}
