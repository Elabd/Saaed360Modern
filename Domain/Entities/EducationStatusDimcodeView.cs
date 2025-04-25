using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EducationStatusDimcodeView
{
    public string EducationStatusDescription { get; set; } = null!;

    public string EducationStatusCode { get; set; } = null!;

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
