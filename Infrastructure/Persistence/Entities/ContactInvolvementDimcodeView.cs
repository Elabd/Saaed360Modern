using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ContactInvolvementDimcodeView
{
    public string ContactInvolvementDescription { get; set; } = null!;

    public string? ContactInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
