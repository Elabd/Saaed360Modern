using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonAffiliation
{
    public long PersonAffiliationId { get; set; }

    public Guid PersonAffiliationGuid { get; set; }

    public string PersonAffiliationDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

    public long SourceId { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
