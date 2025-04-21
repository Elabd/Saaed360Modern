using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class WarrantExtraditionLimitationDimcodeView
{
    public string? WarrantExtraditionLimitationDescription { get; set; }

    public string? WarrantExtraditionLimitationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
