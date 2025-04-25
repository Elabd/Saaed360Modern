using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class UserNationalityCategoryDim
{
    public int UserNationalityCategoryId { get; set; }

    public string Description { get; set; } = null!;

    public string? DescriptionAr { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<CommissionTypeDim> CommissionTypeDims { get; set; } = new List<CommissionTypeDim>();
}
