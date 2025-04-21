using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MilitaryBranchDimcodeView
{
    public string? MilitaryBranchDescription { get; set; }

    public string? MilitaryBranchCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
