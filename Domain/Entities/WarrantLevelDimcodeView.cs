using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class WarrantLevelDimcodeView
{
    public string? WarrantLevelDescription { get; set; }

    public string? WarrantLevelCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
