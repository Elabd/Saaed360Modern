using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DnacollectionStatusDimcodeView
{
    public string? DnacollectionStatusDescription { get; set; }

    public string? DnacollectionStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
