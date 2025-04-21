using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationArea
{
    public long OrganizationAreaId { get; set; }

    public long OrgId { get; set; }

    public long AreaId { get; set; }
}
