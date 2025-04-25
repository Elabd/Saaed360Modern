using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MissingPersonStatusDimcodeView
{
    public string? MissingPersonStatusDescription { get; set; }

    public string? MissingPersonStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
