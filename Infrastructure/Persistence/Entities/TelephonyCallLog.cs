using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TelephonyCallLog
{
    public long Id { get; set; }

    public long? TelephonyCallId { get; set; }

    public string? Status { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public virtual TelephonyCall? TelephonyCall { get; set; }
}
