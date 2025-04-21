using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ProgramStatusDimcodeView
{
    public string? ProgramStatusDescription { get; set; }

    public string? ProgramStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
