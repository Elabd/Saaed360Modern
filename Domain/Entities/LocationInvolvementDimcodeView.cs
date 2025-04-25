using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationInvolvementDimcodeView
{
    public string? LocationInvolvementDescription { get; set; }

    public string? LocationInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
