using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubjectRegistrationCategoryDimcodeView
{
    public string? SubjectRegistrationCategoryDescription { get; set; }

    public string? SubjectRegistrationCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
