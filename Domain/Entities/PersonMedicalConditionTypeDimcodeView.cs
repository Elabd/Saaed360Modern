using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonMedicalConditionTypeDimcodeView
{
    public string? PersonMedicalConditionTypeDescription { get; set; }

    public string? PersonMedicalConditionTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
