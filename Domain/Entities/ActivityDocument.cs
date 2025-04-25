using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityDocument
{
    public long ActivityDocumentId { get; set; }

    public Guid ActivityDocumentGuid { get; set; }

    public string ActivityDocumentDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public Guid DocumentGuid { get; set; }

    public long DocumentId { get; set; }

    public long SourceId { get; set; }

    public int DocumentInvolvementId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Document Document { get; set; } = null!;

    public virtual DocumentInvolvementDim DocumentInvolvement { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
