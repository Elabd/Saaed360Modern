using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AuthorizationTypeDimcodeView
{
    public string? AuthorizationTypeDescription { get; set; }

    public string? AuthorizationTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
