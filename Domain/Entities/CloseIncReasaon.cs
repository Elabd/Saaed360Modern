using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CloseIncReasaon
{
    public long ActivityId { get; set; }

    public int ClosingReason1 { get; set; }

    public string? ClosingComments { get; set; }

    public string? Description { get; set; }

    public int? ClosingReason2 { get; set; }

    public DateTime? ClosingDateTime { get; set; }

    public long? ClosedBy { get; set; }
}
