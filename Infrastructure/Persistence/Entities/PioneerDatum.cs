using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PioneerDatum
{
    public string? SaaedId { get; set; }

    public string? AccidentDateTime { get; set; }

    public string? AccidentEmirate { get; set; }

    public string? UploadDate { get; set; }

    public string? AdpId { get; set; }

    public string? Status { get; set; }

    public string? TicketStatusDateTime { get; set; }

    public int? RetryCount { get; set; }

    public bool? InqueryStatus { get; set; }

    public string? ErrorMessage { get; set; }
}
