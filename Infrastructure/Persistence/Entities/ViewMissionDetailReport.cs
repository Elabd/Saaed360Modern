using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewMissionDetailReport
{
    public long RequestId { get; set; }

    public string? MissionType { get; set; }

    public int MissionTypeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? Duration { get; set; }

    public string? FirstName { get; set; }

    public string? Description { get; set; }

    public long AreaId { get; set; }

    public long PersonId { get; set; }
}
