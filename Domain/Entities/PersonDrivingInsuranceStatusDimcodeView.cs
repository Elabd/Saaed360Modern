using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonDrivingInsuranceStatusDimcodeView
{
    public string? PersonDrivingInsuranceStatusDescription { get; set; }

    public string? PersonDrivingInsuranceStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
