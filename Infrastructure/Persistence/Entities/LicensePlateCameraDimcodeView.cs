using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LicensePlateCameraDimcodeView
{
    public string? LicensePlateCameraDescription { get; set; }

    public string? LicensePlateCameraCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

