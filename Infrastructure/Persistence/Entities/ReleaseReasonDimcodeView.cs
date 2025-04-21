using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReleaseReasonDimcodeView
{
    public string? ReleaseReasonDescription { get; set; }

    public string? ReleaseReasonCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
