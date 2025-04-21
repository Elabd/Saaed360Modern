using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubjectExtraditionDimcodeView
{
    public string? SubjectExtraditionDescription { get; set; }

    public string? SubjectExtraditionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
