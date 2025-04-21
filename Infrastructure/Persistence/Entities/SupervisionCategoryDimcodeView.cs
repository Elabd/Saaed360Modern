using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SupervisionCategoryDimcodeView
{
    public string? SupervisionCategoryDescription { get; set; }

    public string? SupervisionCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
