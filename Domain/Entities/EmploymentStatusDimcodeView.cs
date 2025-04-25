using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EmploymentStatusDimcodeView
{
    public string? EmploymentStatusDescription { get; set; }

    public string? EmploymentStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
