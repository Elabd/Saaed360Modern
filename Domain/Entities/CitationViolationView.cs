using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CitationViolationView
{
    public long CitationViolationId { get; set; }

    public string? CitationViolationDescription { get; set; }

    public long ActivityId { get; set; }

    public string? Observation { get; set; }

    public long CommentId { get; set; }

    public DateTime? ViolationDateTimeStamp { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
