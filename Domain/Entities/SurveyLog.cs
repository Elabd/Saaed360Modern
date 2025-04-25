using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SurveyLog
{
    public long Id { get; set; }

    public long? Order { get; set; }

    public DateTime? AddedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Ipaddress { get; set; }

    public string? Details { get; set; }

    public string? ClassName { get; set; }

    public string? MethodName { get; set; }
}
