using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CitationViolationGuidView
{
    public Guid CitationViolationGuid { get; set; }

    public string? CitationViolationDescription { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? Observation { get; set; }

    public Guid CommentGuid { get; set; }

    public DateTime? ViolationDateTimeStamp { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
