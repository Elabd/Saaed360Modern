using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationUnitLog
{
    public long OrganizationUnitLogId { get; set; }

    public Guid OrganizationUnitLogGuid { get; set; }

    public string OrganizationUnitLogDescription { get; set; } = null!;

    public long OrganizationUnitId { get; set; }

    public Guid OrganizationUnitGuid { get; set; }

    public long? SourceId { get; set; }

    public long? ItemId { get; set; }

    public Guid ItemGuid { get; set; }

    public string? Vehicle { get; set; }

    public DateTime? OnTime { get; set; }

    public DateTime? OffTime { get; set; }

    public int? OrganizationUnitStatusId { get; set; }

    public int? OrganizationUnitCategoryId { get; set; }

    public int? OrganizationLogCategoryId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Item? Item { get; set; }

    public virtual OrganizationLogCategoryDim? OrganizationLogCategory { get; set; }

    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    public virtual OrganizationUnitCategoryDim? OrganizationUnitCategory { get; set; }

    public virtual OrganizationUnitStatusDim? OrganizationUnitStatus { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source? Source { get; set; }
}
