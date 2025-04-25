using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonBodyPartStatusDimcodeView
{
    public string? PersonBodyPartStatusDescription { get; set; }

    public string? PersonBodyPartStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
