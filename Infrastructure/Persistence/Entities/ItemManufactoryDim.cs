using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemManufactoryDim
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? ItemCategoryId { get; set; }

    public virtual ItemCategoryDim? ItemCategory { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
