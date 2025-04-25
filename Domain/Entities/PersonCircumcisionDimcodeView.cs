using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonCircumcisionDimcodeView
{
    public string? PersonCircumcisionDescription { get; set; }

    public string? PersonCircumcisionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
