using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PageActionCategoryDim
{
    public int PageActionCategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Desc { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? CultureDescriptionXml { get; set; }

    public virtual ICollection<PageAction> PageActions { get; set; } = new List<PageAction>();
}
