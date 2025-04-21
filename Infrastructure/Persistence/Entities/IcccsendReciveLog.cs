using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccsendReciveLog
{
    public long Id { get; set; }

    public int RequestType { get; set; }

    public string Value { get; set; } = null!;

    public long? SaaedIncidentId { get; set; }

    public long? IcccincidentId { get; set; }

    public DateTime LoggedTime { get; set; }

    public long CreatedBy { get; set; }
}
