using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonSexualOrientationDimcodeView
{
    public string? PersonSexualOrientationDescription { get; set; }

    public string? PersonSexualOrientationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
