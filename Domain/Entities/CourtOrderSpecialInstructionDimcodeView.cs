using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtOrderSpecialInstructionDimcodeView
{
    public string? CourtOrderSpecialInstructionDescription { get; set; }

    public string? CourtOrderSpecialInstructionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
