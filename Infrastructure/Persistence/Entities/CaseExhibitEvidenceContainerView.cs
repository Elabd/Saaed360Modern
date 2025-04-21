using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CaseExhibitEvidenceContainerView
{
    public long CaseExhibitEvidenceId { get; set; }

    public string? CaseExhibitEvidenceDescription { get; set; }

    public long ActivityId { get; set; }

    public long ItemId { get; set; }

    public string? SourceName { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
