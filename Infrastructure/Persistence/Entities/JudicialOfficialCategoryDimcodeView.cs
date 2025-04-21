using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class JudicialOfficialCategoryDimcodeView
{
    public string? JudicialOfficialCategoryDescription { get; set; }

    public string? JudicialOfficialCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
