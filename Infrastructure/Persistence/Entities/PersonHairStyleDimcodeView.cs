using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonHairStyleDimcodeView
{
    public string? PersonHairStyleDescription { get; set; }

    public string? PersonHairStyleCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
