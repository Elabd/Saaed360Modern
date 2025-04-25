using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OfficerActivityDimcodeView
{
    public string? OfficerActivityDescription { get; set; }

    public string? OfficerActivityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
