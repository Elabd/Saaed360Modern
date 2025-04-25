using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SourceDirectoryCategoryDim
{
    public int SourceDirectoryCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
