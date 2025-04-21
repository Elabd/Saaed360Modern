using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IdentificationAuthorityDimcodeView
{
    public string? IdentificationAuthorityJurisdiction { get; set; }

    public string? IdentificationAuthorityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
