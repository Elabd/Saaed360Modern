using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemIdentifierLocationDim
{
    public int ItemIdentifierLocationId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ItemIdentifier> ItemIdentifiers { get; set; } = new List<ItemIdentifier>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
