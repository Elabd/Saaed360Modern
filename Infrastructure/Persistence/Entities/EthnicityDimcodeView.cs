using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EthnicityDimcodeView
{
    public string? EthnicityDescription { get; set; }

    public string? EthnicityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
