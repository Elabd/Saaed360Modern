using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Server
{
    public string Id { get; set; } = null!;

    public string? Data { get; set; }

    public DateTime LastHeartbeat { get; set; }
}
