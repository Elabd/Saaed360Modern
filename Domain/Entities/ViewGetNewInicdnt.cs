using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewGetNewInicdnt
{
    public long ActivityId { get; set; }

    public long OrganizationId { get; set; }

    public long AreaId { get; set; }

    public DateTime? ActivityDate { get; set; }
}
