using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportModificationRelationshipTypeDim
{
    public int ReportModificationRelationshipTypeId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Desc { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ReportModificationAssociation> ReportModificationAssociations { get; set; } = new List<ReportModificationAssociation>();
}
