using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationDocument
{
    public long OrganizationDocumentId { get; set; }

    public Guid OrganizationDocumentGuid { get; set; }

    public string OrganizationDocumentDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

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

    public virtual Organization Organization { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
