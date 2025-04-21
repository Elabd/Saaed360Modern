using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonInjuryListDimcodeView
{
    public string? PersonInjuryListDescription { get; set; }

    public string? PersonInjuryListCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
