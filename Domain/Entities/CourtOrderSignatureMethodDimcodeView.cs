using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtOrderSignatureMethodDimcodeView
{
    public string? CourtOrderSignatureMethodDescription { get; set; }

    public string? CourtOrderSignatureMethodCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
