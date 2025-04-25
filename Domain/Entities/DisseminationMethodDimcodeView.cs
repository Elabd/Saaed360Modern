using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DisseminationMethodDimcodeView
{
    public string? DisseminationMethodDescription { get; set; }

    public string? DisseminationMethodCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
