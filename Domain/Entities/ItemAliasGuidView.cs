using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemAliasGuidView
{
    public Guid ItemAliasGuid { get; set; }

    public string ItemAliasDescription { get; set; } = null!;

    public Guid ItemGuid { get; set; }

    public string? Alias { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
