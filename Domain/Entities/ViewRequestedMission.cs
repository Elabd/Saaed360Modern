using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewRequestedMission
{
    public long RequestMissionId { get; set; }

    public long AreaId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public string? ActivityReasonDescription { get; set; }

    public string? PersonName { get; set; }
}
