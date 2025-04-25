using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonMoruaryDimcodeView
{
    public string? PersonMoruaryDescription { get; set; }

    public string? PersonMoruaryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
