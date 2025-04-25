using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DentalStatusDimcodeView
{
    public string? DentalStatusDescription { get; set; }

    public string? DentalStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
