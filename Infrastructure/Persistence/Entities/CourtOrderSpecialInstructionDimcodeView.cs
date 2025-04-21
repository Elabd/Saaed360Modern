using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CourtOrderSpecialInstructionDimcodeView
{
    public string? CourtOrderSpecialInstructionDescription { get; set; }

    public string? CourtOrderSpecialInstructionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
