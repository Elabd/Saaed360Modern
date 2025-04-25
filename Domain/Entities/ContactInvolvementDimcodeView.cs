using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ContactInvolvementDimcodeView
{
    public string ContactInvolvementDescription { get; set; } = null!;

    public string? ContactInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
