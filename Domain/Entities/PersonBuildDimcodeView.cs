using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonBuildDimcodeView
{
    public string? PersonBuildDescription { get; set; }

    public string? PersonBuildCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
