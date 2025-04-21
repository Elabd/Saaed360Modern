using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonEyeColorDimcodeView
{
    public string? PersonEyeColorDescription { get; set; }

    public string? PersonEyeColorCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
