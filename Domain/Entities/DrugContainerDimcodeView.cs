using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DrugContainerDimcodeView
{
    public string? DrugContainerDescription { get; set; }

    public string? DrugContainerCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
