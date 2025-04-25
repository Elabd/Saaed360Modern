using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SupervisionStatusDimcodeView
{
    public string? SupervisionStatusDescription { get; set; }

    public string? SupervisionStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
