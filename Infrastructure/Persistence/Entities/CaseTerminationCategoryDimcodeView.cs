using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CaseTerminationCategoryDimcodeView
{
    public string? CaseTerminationCategoryDescription { get; set; }

    public string? CaseTerminationCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
