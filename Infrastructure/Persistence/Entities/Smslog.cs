using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Smslog
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string MobileNumber { get; set; } = null!;

    public string Message { get; set; } = null!;

    public DateTime ActionDate { get; set; }
}
