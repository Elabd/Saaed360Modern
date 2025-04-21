using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class BondTerminationCategoryDimcodeView
{
    public string? BondTerminationCategoryDescription { get; set; }

    public string? BondTerminationCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
