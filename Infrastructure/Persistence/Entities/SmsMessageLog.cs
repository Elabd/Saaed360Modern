using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SmsMessageLog
{
    public Guid Id { get; set; }

    public DateTime CreationDate { get; set; }

    public long? TemplateId { get; set; }

    public string Text { get; set; } = null!;

    public bool SentSuccessfully { get; set; }

    public string? Referrer { get; set; }

    public string? MobileNumber { get; set; }

    public bool? ViolateHoldPeriod { get; set; }
}
