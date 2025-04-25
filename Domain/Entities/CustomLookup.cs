using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CustomLookup
{
    public int CustomLookupId { get; set; }

    public string? TableName { get; set; }

    public int? Id { get; set; }

    public bool? IsShown { get; set; }

    public string? Description { get; set; }

    public DateTime? TimeStamp { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
