using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IntegrationTokenLog
{
    public long Id { get; set; }

    public string Token { get; set; } = null!;

    public long UserId { get; set; }

    public int? SourceTypeId { get; set; }

    public long? SourceId { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public DateTime CreationDate { get; set; }
}
