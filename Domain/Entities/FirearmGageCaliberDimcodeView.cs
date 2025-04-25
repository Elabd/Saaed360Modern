using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FirearmGageCaliberDimcodeView
{
    public string? FirearmGageCaliberDescription { get; set; }

    public string? FirearmGageCaliberCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
