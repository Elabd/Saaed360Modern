using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EmploymentOccupationDimcodeView
{
    public string? EmploymentOccupationDescription { get; set; }

    public string? EmploymentOccupationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
