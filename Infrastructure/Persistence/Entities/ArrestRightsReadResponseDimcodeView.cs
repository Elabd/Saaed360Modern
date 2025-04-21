using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ArrestRightsReadResponseDimcodeView
{
    public string? ArrestRightsReadResponseDescription { get; set; }

    public string? ArrestRightsReadResponseCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
