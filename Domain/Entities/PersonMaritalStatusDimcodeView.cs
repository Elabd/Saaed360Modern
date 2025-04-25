using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonMaritalStatusDimcodeView
{
    public string? PersonMaritalStatusDescription { get; set; }

    public string? PersonMaritalStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
