using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonLocation
{
    public long PersonLocationId { get; set; }

    public Guid PersonLocationGuid { get; set; }

    public string PersonLocationDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long LocationId { get; set; }

    public Guid LocationGuid { get; set; }

    public int LocationInvolvementId { get; set; }

    public long SourceId { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public DateTime? FromDateTimeStamp { get; set; }

    public DateTime? ToDateTimeStamp { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual LocationInvolvementDim LocationInvolvement { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
