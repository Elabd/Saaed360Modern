using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonHandednessDimcodeView
{
    public string? PersonHandednessDescription { get; set; }

    public string? PersonHandednessCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
