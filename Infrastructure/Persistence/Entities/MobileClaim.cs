using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileClaim
{
    public long MobileClaimId { get; set; }

    public string ClaimNumber { get; set; } = null!;

    public DateTime ClaimDate { get; set; }

    public DateTime CreationDate { get; set; }

    public long UserId { get; set; }

    public string AccidentNumber { get; set; } = null!;

    public long ReportId { get; set; }
}
