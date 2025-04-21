using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityAutoDispatch
{
    public long Id { get; set; }

    public long ActivityId { get; set; }

    public long CallTakerId { get; set; }

    public long AreaId { get; set; }

    public DateTime CreationDate { get; set; }

    public bool IsDispatched { get; set; }

    public DateTime? DispatchDate { get; set; }

    public bool? DispatchResult { get; set; }
}
