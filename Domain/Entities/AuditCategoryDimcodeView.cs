using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AuditCategoryDimcodeView
{
    public string? AuditCategoryDescription { get; set; }

    public string? AuditCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
