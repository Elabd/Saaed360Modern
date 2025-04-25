using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonMedicalByDimcodeView
{
    public string? PersonMedicalByDescription { get; set; }

    public string? PersonMedicalByCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
