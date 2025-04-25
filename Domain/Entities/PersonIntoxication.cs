using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonIntoxication
{
    public long PersonIntoxicationId { get; set; }

    public Guid PersonIntoxicationGuid { get; set; }

    public string PersonIntoxicationDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public int? IntoxicationIntoxicantCategoryId { get; set; }

    public int? IntoxicationLevelId { get; set; }

    public DateTime? EntryDateTime { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual IntoxicationIntoxicantCategoryDim? IntoxicationIntoxicantCategory { get; set; }

    public virtual IntoxicationLevelDim? IntoxicationLevel { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
