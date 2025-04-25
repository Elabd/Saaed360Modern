using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationArea
{
    public long OrganizationAreaId { get; set; }

    public long OrgId { get; set; }

    public long AreaId { get; set; }
}
