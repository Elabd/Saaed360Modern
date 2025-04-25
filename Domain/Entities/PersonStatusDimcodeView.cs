using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonStatusDimcodeView
{
    public string? PersonStatusDescription { get; set; }

    public string? PersonStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
