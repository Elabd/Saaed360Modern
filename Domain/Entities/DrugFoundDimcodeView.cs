using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DrugFoundDimcodeView
{
    public string? DrugFoundDescription { get; set; }

    public string? DrugFoundCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
