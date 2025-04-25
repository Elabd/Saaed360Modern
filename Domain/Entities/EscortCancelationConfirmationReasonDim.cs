using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EscortCancelationConfirmationReasonDim
{
    public int EscortCancelationConfirmationReasonId { get; set; }

    public string DescriptionAr { get; set; } = null!;

    public string? DescriptionEn { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? VersionDateTime { get; set; }

    public virtual ICollection<EscortMissionCancelationLog> EscortMissionCancelationLogs { get; set; } = new List<EscortMissionCancelationLog>();
}
