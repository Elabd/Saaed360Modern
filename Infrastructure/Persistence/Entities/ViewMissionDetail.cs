using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewMissionDetail
{
    public long ItemId { get; set; }

    public long RequestId { get; set; }

    public long AcceptId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public int MissionTypeId { get; set; }

    public string? MissionType { get; set; }

    public string? MissionCode { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? PatrolCode { get; set; }

    public string? Comment { get; set; }

    public long AreaId { get; set; }

    public int StatusId { get; set; }
}
