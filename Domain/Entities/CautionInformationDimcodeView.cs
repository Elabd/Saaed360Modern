using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CautionInformationDimcodeView
{
    public string? CautionInformationDescription { get; set; }

    public string? CautionInformationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
