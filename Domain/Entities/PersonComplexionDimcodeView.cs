using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonComplexionDimcodeView
{
    public string? PersonComplexionDescription { get; set; }

    public string? PersonComplexionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
