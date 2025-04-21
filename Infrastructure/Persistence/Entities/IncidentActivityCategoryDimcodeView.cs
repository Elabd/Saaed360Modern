using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentActivityCategoryDimcodeView
{
    public string? IncidentActivityCategoryDescription { get; set; }

    public string? IncidentActivityCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
