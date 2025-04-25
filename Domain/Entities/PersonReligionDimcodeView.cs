using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonReligionDimcodeView
{
    public string? PersonReligionDescription { get; set; }

    public string? PersonReligionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
