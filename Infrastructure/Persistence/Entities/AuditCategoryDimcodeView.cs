using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AuditCategoryDimcodeView
{
    public string? AuditCategoryDescription { get; set; }

    public string? AuditCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
