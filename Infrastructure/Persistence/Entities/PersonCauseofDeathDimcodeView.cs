using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonCauseofDeathDimcodeView
{
    public string? PersonCauseofDeathDescription { get; set; }

    public string? PersonCauseofDeathCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
