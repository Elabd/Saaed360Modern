using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubscriptionInvolvementDimcodeView
{
    public string SubscriptionInvolvementDescription { get; set; } = null!;

    public string SubscriptionInvolvementCode { get; set; } = null!;

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
