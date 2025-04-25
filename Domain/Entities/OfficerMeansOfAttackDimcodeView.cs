using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OfficerMeansOfAttackDimcodeView
{
    public string? OfficerMeansOfAttackDescription { get; set; }

    public string? OfficerMeansOfAttackCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
