using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DriverLicenseCivilianClassDimcodeView
{
    public string? DriverLicenseCivilianClassDescription { get; set; }

    public string? DriverLicenseCivilianClassCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

