using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Court
{
    public long OrganizationId { get; set; }

    public int? CourtCategoryId { get; set; }

    public virtual CourtCategoryDim? CourtCategory { get; set; }

    public virtual Organization Organization { get; set; } = null!;
}
