using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonMedicalCautionDimcodeView
{
    public string? PersonMedicalCautionDescription { get; set; }

    public string? PersonMedicalCautionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
