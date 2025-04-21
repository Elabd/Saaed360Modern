using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EducationDegreeDimcodeView
{
    public string EducationDegreeDescription { get; set; } = null!;

    public string EducationDegreeCode { get; set; } = null!;

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
