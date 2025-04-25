using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SupportTablesAndRelation
{
    public int RowNo { get; set; }

    public string Table { get; set; } = null!;

    public string? AssociatedParentTable { get; set; }

    public string? AssociationType { get; set; }

    public string? ParentTable { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
