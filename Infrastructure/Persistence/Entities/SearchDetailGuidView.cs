using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SearchDetailGuidView
{
    public Guid SearchDetailGuid { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? ParameterCode { get; set; }

    public string? DataTypeCode { get; set; }

    public string? CompareCode { get; set; }

    public string? ParameterValue { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
