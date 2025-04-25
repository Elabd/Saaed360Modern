using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MissingPersonCircumstanceDimcodeView
{
    public string? MissingPersonCircumstanceDescription { get; set; }

    public string? MissingPersonCircumstanceCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
