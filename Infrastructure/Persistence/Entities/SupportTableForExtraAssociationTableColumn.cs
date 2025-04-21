using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SupportTableForExtraAssociationTableColumn
{
    public string AssociationTableName { get; set; } = null!;

    public string ExtraColumnName { get; set; } = null!;

    public string ColumnValue { get; set; } = null!;

    public long AssociatedEntityId { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
