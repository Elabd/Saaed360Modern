using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FirearmFinishDimcodeView
{
    public string? FirearmFinishDescription { get; set; }

    public string? FirearmFinishCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
