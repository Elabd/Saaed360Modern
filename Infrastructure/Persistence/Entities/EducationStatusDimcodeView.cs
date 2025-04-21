using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EducationStatusDimcodeView
{
    public string EducationStatusDescription { get; set; } = null!;

    public string EducationStatusCode { get; set; } = null!;

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
