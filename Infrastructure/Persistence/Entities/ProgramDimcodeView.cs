using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ProgramDimcodeView
{
    public string ProgramCode { get; set; } = null!;

    public string? ProgramDescription { get; set; }

    public string ProgramProgramName { get; set; } = null!;

    public string? ProgramProgramCategory { get; set; }

    public string? ProgramProgramArea { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
