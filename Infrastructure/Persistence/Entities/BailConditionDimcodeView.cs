using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class BailConditionDimcodeView
{
    public string? BailConditionDescription { get; set; }

    public string? BailConditionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
