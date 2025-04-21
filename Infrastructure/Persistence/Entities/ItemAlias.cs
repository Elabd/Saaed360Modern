using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemAlias
{
    public long ItemAliasId { get; set; }

    public Guid ItemAliasGuid { get; set; }

    public string ItemAliasDescription { get; set; } = null!;

    public long SourceId { get; set; }

    public long ItemId { get; set; }

    public Guid ItemGuid { get; set; }

    public string? Alias { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
