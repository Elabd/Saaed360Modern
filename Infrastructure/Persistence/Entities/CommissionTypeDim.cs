using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CommissionTypeDim
{
    public int CommissionTypeId { get; set; }

    public string? Description { get; set; }

    public double? Commission { get; set; }

    public int? UserNationalityCategoryId { get; set; }

    public virtual UserNationalityCategoryDim? UserNationalityCategory { get; set; }
}
