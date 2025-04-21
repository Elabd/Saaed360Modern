using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AreaRelationshipCategoryDim
{
    public int AreaRelationshipCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? NiemtypeName { get; set; }

    public string? Niem { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<AreaAssociation> AreaAssociations { get; set; } = new List<AreaAssociation>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
