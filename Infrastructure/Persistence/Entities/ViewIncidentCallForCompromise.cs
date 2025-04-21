using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewIncidentCallForCompromise
{
    public long ActivityId { get; set; }

    public long RelatedActivityId { get; set; }

    public string? ContactInformation { get; set; }

    public string? ContactName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }
}
