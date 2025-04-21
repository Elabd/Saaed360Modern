using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IdentificationClassDimcodeView
{
    public string? IdentificationClassDescription { get; set; }

    public string? IdentificationClassCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
