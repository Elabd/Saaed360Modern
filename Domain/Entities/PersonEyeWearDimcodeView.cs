using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonEyeWearDimcodeView
{
    public string? PersonEyeWearDescription { get; set; }

    public string? PersonEyeWearCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
