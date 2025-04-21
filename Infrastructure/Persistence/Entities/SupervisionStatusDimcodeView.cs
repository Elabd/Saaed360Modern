using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SupervisionStatusDimcodeView
{
    public string? SupervisionStatusDescription { get; set; }

    public string? SupervisionStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
