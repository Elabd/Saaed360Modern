using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ApplicationPagesCategoryDim
{
    public int ApplicationPagesCategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Desc { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? CultureDescriptionXml { get; set; }

    public virtual ICollection<ApplicationPage> ApplicationPages { get; set; } = new List<ApplicationPage>();
}
