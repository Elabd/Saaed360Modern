using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CriminalInvolvementDimcodeView
{
    public string? CriminalInvolvementDescription { get; set; }

    public string? CriminalInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
