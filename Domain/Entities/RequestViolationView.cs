using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestViolationView
{
    public long RequestViolationId { get; set; }

    public long ActivityId { get; set; }

    public string? SourceName { get; set; }

    public string? RequestViolationCategoryCode { get; set; }

    public string? RequestViolationCategoryDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
