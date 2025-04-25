using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccviewIncidentPopupPatrol
{
    public long ActivityId { get; set; }

    public long PatrolId { get; set; }

    public string? PatrolCode { get; set; }

    public string? PatrolType { get; set; }

    public string? OrganizationName { get; set; }

    public string? PatrolStatus { get; set; }
}
