using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtOrderRecallReasonDimcodeView
{
    public string? CourtOrderRecallReasonDescription { get; set; }

    public string? CourtOrderRecallReasonCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
