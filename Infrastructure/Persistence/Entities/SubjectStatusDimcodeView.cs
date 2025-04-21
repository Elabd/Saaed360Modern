using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubjectStatusDimcodeView
{
    public string? SubjectStatusDescription { get; set; }

    public string? SubjectStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
