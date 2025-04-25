using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Agency
{
    public long OrganizationId { get; set; }

    public int AgencyCategoryId { get; set; }

    public string? Ori { get; set; }

    public string? Identifier { get; set; }

    public virtual AgencyCategoryDim AgencyCategory { get; set; } = null!;

    public virtual Organization Organization { get; set; } = null!;
}
