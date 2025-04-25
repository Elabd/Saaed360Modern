using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EducationScheduleDayDimcodeView
{
    public string? EducationScheduleDayDescription { get; set; }

    public string? EducationScheduleDayCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
