using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IntoxicationLevelDimcodeView
{
    public string? IntoxicationLevelDescription { get; set; }

    public string? IntoxicationLevelCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
