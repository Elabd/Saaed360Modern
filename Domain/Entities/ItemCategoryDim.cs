using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemCategoryDim
{
    public int ItemCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Category { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ItemMakeModelDim> ItemMakeModelDims { get; set; } = new List<ItemMakeModelDim>();

    public virtual ICollection<ItemManufactoryDim> ItemManufactoryDims { get; set; } = new List<ItemManufactoryDim>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
