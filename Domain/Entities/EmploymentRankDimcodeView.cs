using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EmploymentRankDimcodeView
{
    public string? EmploymentRankDescription { get; set; }

    public string? EmploymentRankCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
