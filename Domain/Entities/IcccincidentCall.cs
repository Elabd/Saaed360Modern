using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccincidentCall
{
    public long ActivityId { get; set; }

    public long RelatedActivityId { get; set; }

    public string? Code { get; set; }

    public long? PersonId { get; set; }

    public string? Expr1 { get; set; }

    public string? ContactInformation { get; set; }

    public string? ContactName { get; set; }

    public int? LanguageId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public string? Address { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }
}
