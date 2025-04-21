using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CourtOrderSignatureMethodDimcodeView
{
    public string? CourtOrderSignatureMethodDescription { get; set; }

    public string? CourtOrderSignatureMethodCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
