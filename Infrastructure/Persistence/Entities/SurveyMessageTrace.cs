using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SurveyMessageTrace
{
    public long Id { get; set; }

    public long? SurveyMessageId { get; set; }

    public string? Message { get; set; }

    public bool? IsException { get; set; }

    public DateTime TimeStamp { get; set; }
}
