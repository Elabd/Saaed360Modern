using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AlertAudienceDimcodeView
{
    public string? AlertAudienceDescription { get; set; }

    public string? AlertAudienceCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
