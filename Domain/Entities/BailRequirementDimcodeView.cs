using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BailRequirementDimcodeView
{
    public string? BailRequirementDescription { get; set; }

    public string? BailRequirementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
