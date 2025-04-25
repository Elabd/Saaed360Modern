using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemMakeModelDim
{
    public int ItemMakeModelId { get; set; }

    public string Code { get; set; } = null!;

    public int? ItemCategoryId { get; set; }

    public string? Make { get; set; }

    public string? MakeCode { get; set; }

    public string? Model { get; set; }

    public string? ModelCode { get; set; }

    public string? Vst { get; set; }

    public string? Reference { get; set; }

    public string? CountryCode { get; set; }

    public DateTime VersionDateTime { get; set; }

    public string? Description { get; set; }

    public int? RowStatusId { get; set; }

    public int? ItemManufactoryId { get; set; }

    public virtual ItemCategoryDim? ItemCategory { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
