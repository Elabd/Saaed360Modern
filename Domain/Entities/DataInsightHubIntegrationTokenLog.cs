using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DataInsightHubIntegrationTokenLog
{
    public Guid Id { get; set; }

    public string Token { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public long UserId { get; set; }
}
