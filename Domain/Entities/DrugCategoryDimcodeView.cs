using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DrugCategoryDimcodeView
{
    public string? DrugCategoryDescription { get; set; }

    public string? DrugCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
