using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonInjuryLevelDimcodeView
{
    public string? PersonInjuryLevelDescription { get; set; }

    public string? PersonInjuryLevelCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
