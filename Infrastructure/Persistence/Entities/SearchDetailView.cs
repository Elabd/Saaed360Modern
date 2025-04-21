using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SearchDetailView
{
    public long SearchDetailId { get; set; }

    public long ActivityId { get; set; }

    public string? ParameterCode { get; set; }

    public string? ParameterDescription { get; set; }

    public string? DataTypeCode { get; set; }

    public string? DataTypeDescription { get; set; }

    public string? CompareCode { get; set; }

    public string? CompareDescription { get; set; }

    public string? ParameterValue { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
