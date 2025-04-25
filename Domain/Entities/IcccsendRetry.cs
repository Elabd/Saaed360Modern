using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccsendRetry
{
    public long Id { get; set; }

    public long IcccincidentId { get; set; }

    public long SaaedIncidentId { get; set; }

    public string DtoObject { get; set; } = null!;

    public bool Succeeded { get; set; }

    public int RetryCount { get; set; }

    public int Icccservice { get; set; }

    public int RequestType { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
