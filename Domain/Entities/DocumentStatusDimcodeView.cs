using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DocumentStatusDimcodeView
{
    public string? DocumentStatusDescription { get; set; }

    public string? DocumentStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
