using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EmploymentWorkShiftDimcodeView
{
    public string? EmploymentWorkShiftDescription { get; set; }

    public string? EmploymentWorkShiftCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
