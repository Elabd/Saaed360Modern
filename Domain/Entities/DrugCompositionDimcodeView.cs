using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DrugCompositionDimcodeView
{
    public string? DrugCompositionDescription { get; set; }

    public string? DrugCompositionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
