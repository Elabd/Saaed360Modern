using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ConditionGroupDimcodeView
{
    public string? ConditionGroupDescription { get; set; }

    public string? ConditionGroupCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
