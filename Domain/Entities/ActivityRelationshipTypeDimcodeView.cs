using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityRelationshipTypeDimcodeView
{
    public string? ActivityRelationshipTypeDescription { get; set; }

    public string? ActivityRelationshipTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
