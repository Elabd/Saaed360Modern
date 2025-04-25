using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationStreetDirectionDimcodeView
{
    public string? LocationStreetDirectionDescription { get; set; }

    public string? LocationStreetDirectionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
