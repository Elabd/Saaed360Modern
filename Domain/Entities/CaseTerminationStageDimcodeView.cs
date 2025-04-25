using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CaseTerminationStageDimcodeView
{
    public string? CaseTerminationStageDescription { get; set; }

    public string? CaseTerminationStageCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
