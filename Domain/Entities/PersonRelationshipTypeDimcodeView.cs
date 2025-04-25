using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonRelationshipTypeDimcodeView
{
    public string? PersonRelationshipTypeDescription { get; set; }

    public string? PersonRelationshipTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
