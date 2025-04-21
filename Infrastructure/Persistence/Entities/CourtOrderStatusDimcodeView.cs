using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CourtOrderStatusDimcodeView
{
    public string? CourtOrderStatusDescription { get; set; }

    public string? CourtOrderStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
