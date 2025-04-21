using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonBodyXrayDimcodeView
{
    public string? PersonBodyXrayDescription { get; set; }

    public string? PersonBodyXrayCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
