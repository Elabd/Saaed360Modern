using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonHairAppearanceDimcodeView
{
    public string? PersonHairAppearanceDescription { get; set; }

    public string? PersonHairAppearanceCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
