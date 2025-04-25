using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonMedicationDimcodeView
{
    public string? PersonMedicationDescription { get; set; }

    public string? PersonMedicationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
