using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AlertInstructionDimcodeView
{
    public string? AlertInstructionDescription { get; set; }

    public string? AlertInstructionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
