using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AircraftCategoryDimcodeView
{
    public string? AircraftCategoryDescription { get; set; }

    public string? AircraftCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
