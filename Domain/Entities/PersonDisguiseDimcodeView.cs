using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonDisguiseDimcodeView
{
    public string? PersonDisguiseDescription { get; set; }

    public string? PersonDisguiseCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
