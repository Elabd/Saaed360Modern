using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewMdtpersonAreaSyncHelper
{
    public long PersonAreaId { get; set; }

    public long? PersonId { get; set; }

    public long? AreaId { get; set; }
}
