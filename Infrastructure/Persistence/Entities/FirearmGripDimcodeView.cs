using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FirearmGripDimcodeView
{
    public string? FirearmGripDescription { get; set; }

    public string? FirearmGripCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
