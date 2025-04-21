using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EmploymentWorkShiftDimcodeView
{
    public string? EmploymentWorkShiftDescription { get; set; }

    public string? EmploymentWorkShiftCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
