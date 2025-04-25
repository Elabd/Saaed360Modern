using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ProgramReferralStatusDimcodeView
{
    public string? ProgramReferralStatusDescription { get; set; }

    public string? ProgramReferralStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
