using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class StatusDimcodeView
{
    public string? StatusDescription { get; set; }

    public string? StatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
