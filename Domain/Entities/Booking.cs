using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Booking
{
    public long ActivityId { get; set; }

    public string? DocumentControlIdentification { get; set; }

    public DateTime? TelephoneCallDate { get; set; }

    public DateTime? ArraignmentDate { get; set; }

    public string? AgencyRecordIdentification { get; set; }

    public string? FileIdentification { get; set; }

    public bool SealedIndicator { get; set; }

    public virtual Activity Activity { get; set; } = null!;
}
