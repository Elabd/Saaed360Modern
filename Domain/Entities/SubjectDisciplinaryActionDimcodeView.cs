using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubjectDisciplinaryActionDimcodeView
{
    public string? SubjectDisciplinaryActionDescription { get; set; }

    public string? SubjectDisciplinaryActionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
