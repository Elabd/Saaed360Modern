using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RowStatusDimcodeView
{
    public string RowStatusDescription { get; set; } = null!;

    public string RowStatusCode { get; set; } = null!;

    public bool? IsShown { get; set; }
}
