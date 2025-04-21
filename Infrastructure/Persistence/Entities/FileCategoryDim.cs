using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FileCategoryDim
{
    public long FileCategoryId { get; set; }

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public DateTime? VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<File> Files { get; set; } = new List<File>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
