using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LocationDocument
{
    public long LocationDocumentId { get; set; }

    public Guid LocationDocumentGuid { get; set; }

    public string LocationDocumentDescription { get; set; } = null!;

    public long LocationId { get; set; }

    public Guid LocationGuid { get; set; }

    public long DocumentId { get; set; }

    public Guid DocumentGuid { get; set; }

    public int DocumentInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Document Document { get; set; } = null!;

    public virtual DocumentInvolvementDim DocumentInvolvement { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
