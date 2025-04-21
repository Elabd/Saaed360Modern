using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DrugCompositionDimcodeView
{
    public string? DrugCompositionDescription { get; set; }

    public string? DrugCompositionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
