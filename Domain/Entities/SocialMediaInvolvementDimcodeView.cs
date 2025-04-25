using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaInvolvementDimcodeView
{
    public string? SocialMediaInvolvementDescription { get; set; }

    public string? SocialMediaInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
