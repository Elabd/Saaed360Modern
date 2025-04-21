using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncdentBisync
{
    public long Id { get; set; }

    public long ActivityId { get; set; }

    public DateTime CreationDate { get; set; }

    public bool IsTransfered { get; set; }

    public DateTime? TransferDate { get; set; }

    public bool? IsUpdated { get; set; }

    public bool? IsReportTransfared { get; set; }

    public long? LastReportId { get; set; }

    public bool? IsLocationSync { get; set; }
}
