using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ConditionViolationDimcodeView
{
    public string? ConditionViolationDescription { get; set; }

    public string? ConditionViolationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
