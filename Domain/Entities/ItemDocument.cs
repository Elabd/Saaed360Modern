using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemDocument
{
    public long ItemDocumentId { get; set; }

    public Guid ItemDocumentGuid { get; set; }

    public string ItemDocumentDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public Guid ItemGuid { get; set; }

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

    public virtual Item Item { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
