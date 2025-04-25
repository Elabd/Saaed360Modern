using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GeoZipDimcodeView
{
    public string GeoZipCode { get; set; } = null!;

    public string? GeoZipZipCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
