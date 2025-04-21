using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonHairColorDimcodeView
{
    public string? PersonHairColorDescription { get; set; }

    public string? PersonHairColorCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
