using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OfficerAssignmentDimcodeView
{
    public string? OfficerAssignmentDescription { get; set; }

    public string? OfficerAssignmentCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
