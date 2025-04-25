using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewContorlCenterRelatedArea
{
    public long ControlCenterId { get; set; }

    public string? ControlCenterName { get; set; }

    public long AreaId { get; set; }

    public string? AreaCode { get; set; }

    public string? AreaDescription { get; set; }

    public long EmairaId { get; set; }

    public int? AreaOrder { get; set; }
}
