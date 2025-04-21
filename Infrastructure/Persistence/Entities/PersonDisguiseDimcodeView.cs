using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonDisguiseDimcodeView
{
    public string? PersonDisguiseDescription { get; set; }

    public string? PersonDisguiseCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
