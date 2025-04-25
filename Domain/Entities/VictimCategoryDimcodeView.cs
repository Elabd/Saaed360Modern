using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VictimCategoryDimcodeView
{
    public string? VictimCategoryDescription { get; set; }

    public string? VictimCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
