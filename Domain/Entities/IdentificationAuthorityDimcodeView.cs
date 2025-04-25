using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IdentificationAuthorityDimcodeView
{
    public string? IdentificationAuthorityJurisdiction { get; set; }

    public string? IdentificationAuthorityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
