using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RowStatusDimcodeView
{
    public string RowStatusDescription { get; set; } = null!;

    public string RowStatusCode { get; set; } = null!;

    public bool? IsShown { get; set; }
}
