using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtOrderServiceCautionDimcodeView
{
    public string? CourtOrderServiceCautionDescription { get; set; }

    public string? CourtOrderServiceCautionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

