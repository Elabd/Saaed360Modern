using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EmploymentDepartmentDimcodeView
{
    public string? EmploymentDepartmentDescription { get; set; }

    public string? EmploymentDepartmentCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
