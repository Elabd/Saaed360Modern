using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MdtViewCheckUserLogin
{
    public long MainLoginId { get; set; }

    public long TeamId { get; set; }

    public long PatrolId { get; set; }

    public string? PatrolCode { get; set; }

    public DateTime? MainLoginDate { get; set; }

    public long TempLogoutRequestId { get; set; }

    public DateTime? TempLogoutRequestAcceptDate { get; set; }

    public long TempLoginId { get; set; }

    public DateTime? TempLoginTime { get; set; }

    public int IsTempLoginRequired { get; set; }

    public int IsLogoutOccurred { get; set; }
}
