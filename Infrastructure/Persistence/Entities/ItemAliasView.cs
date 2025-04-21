using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemAliasView
{
    public long ItemAliasId { get; set; }

    public string ItemAliasDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public string? Alias { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
