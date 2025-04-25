using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonDrivingInsCoverageCategoryDimcodeView
{
    public string? PersonDrivingInsCoverageCategoryDescription { get; set; }

    public string? PersonDrivingInsCoverageCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
