using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SupervisionCustodyStatusDimcodeView
{
    public string? SupervisionCustodyStatusDescription { get; set; }

    public string? SupervisionCustodyStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
