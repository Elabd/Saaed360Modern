using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonGeneralAppearanceDimcodeView
{
    public string? PersonGeneralAppearanceDescription { get; set; }

    public string? PersonGeneralAppearanceCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
