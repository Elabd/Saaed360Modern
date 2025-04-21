using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentExceptionalClearanceDimcodeView
{
    public string? IncidentExceptionalClearanceDescription { get; set; }

    public string? IncidentExceptionalClearanceCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
