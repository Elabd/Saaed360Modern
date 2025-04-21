using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FirearmFinishDimcodeView
{
    public string? FirearmFinishDescription { get; set; }

    public string? FirearmFinishCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
