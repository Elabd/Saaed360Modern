using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonMedicationDimcodeView
{
    public string? PersonMedicationDescription { get; set; }

    public string? PersonMedicationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
