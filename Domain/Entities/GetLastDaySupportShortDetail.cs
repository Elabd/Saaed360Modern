using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GetLastDaySupportShortDetail
{
    public long ActivityItemId { get; set; }

    public long ActivityId { get; set; }

    public long Organizationid { get; set; }

    public long? CurrentStatusId { get; set; }

    public Guid? WorkFlowGuid { get; set; }
}
