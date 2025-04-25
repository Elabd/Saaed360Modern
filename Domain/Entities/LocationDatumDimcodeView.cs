using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationDatumDimcodeView
{
    public string? LocationDatumDescription { get; set; }

    public string? LocationDatumCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
