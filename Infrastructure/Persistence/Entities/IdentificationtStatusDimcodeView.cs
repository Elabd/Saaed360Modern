using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IdentificationtStatusDimcodeView
{
    public string? IdentificationtStatusDescription { get; set; }

    public string? IdentificationtStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
