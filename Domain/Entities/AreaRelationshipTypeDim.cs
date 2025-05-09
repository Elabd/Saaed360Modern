using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AreaRelationshipTypeDim
{
    public int AreaRelationshipTypeId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<AreaAssociation> AreaAssociations { get; set; } = new List<AreaAssociation>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
