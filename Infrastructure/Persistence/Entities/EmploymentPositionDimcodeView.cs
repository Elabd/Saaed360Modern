using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EmploymentPositionDimcodeView
{
    public string? EmploymentPositionDescription { get; set; }

    public string? EmploymentPositionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
