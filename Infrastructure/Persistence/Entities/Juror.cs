using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Juror
{
    public long PersonId { get; set; }

    public string? JurorIdentification { get; set; }

    public string? JurorPanelIdentification { get; set; }

    public DateTime? JurorDismissedDate { get; set; }

    public bool JurorDismissedIndicator { get; set; }

    public int JurorDismissedReasonId { get; set; }

    public bool JurorForemanIndicator { get; set; }

    public bool JurorPrimaryIndicator { get; set; }

    public virtual JurorDismissedReasonDim JurorDismissedReason { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
