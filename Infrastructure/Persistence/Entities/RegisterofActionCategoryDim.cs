using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RegisterofActionCategoryDim
{
    public int RegisterofActionCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<RegisterofAction> RegisterofActions { get; set; } = new List<RegisterofAction>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
