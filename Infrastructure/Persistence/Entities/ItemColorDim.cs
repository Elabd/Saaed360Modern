using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemColorDim
{
    public int ItemColorId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<Aircraft> AircraftFuselageColors { get; set; } = new List<Aircraft>();

    public virtual ICollection<Aircraft> AircraftWingColors { get; set; } = new List<Aircraft>();

    public virtual ICollection<Item> ItemItemPrimaryColors { get; set; } = new List<Item>();

    public virtual ICollection<Item> ItemItemSecondaryColors { get; set; } = new List<Item>();

    public virtual ICollection<JewelryStone> JewelryStones { get; set; } = new List<JewelryStone>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
