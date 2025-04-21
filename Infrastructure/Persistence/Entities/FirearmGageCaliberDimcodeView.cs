using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FirearmGageCaliberDimcodeView
{
    public string? FirearmGageCaliberDescription { get; set; }

    public string? FirearmGageCaliberCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
