using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DocumentInvolvementDimcodeView
{
    public string? DocumentInvolvementDescription { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
