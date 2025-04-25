using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityRelationshipTypeDim
{
    public int ActivityRelationshipTypeId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ActivityAssociation> ActivityAssociations { get; set; } = new List<ActivityAssociation>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
