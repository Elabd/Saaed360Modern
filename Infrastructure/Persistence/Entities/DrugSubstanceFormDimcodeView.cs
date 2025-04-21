using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DrugSubstanceFormDimcodeView
{
    public string? DrugSubstanceFormDescription { get; set; }

    public string? DrugSubstanceFormCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
