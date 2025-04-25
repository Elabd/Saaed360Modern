using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VwAttendanceHistoryLog
{
    public long PersonId { get; set; }

    public string? FirstName { get; set; }

    public string UserName { get; set; } = null!;

    public string? LastName { get; set; }

    public DateTime? CheckinDate { get; set; }

    public DateTime? CheckoutDate { get; set; }

    public long PatrolId { get; set; }

    public string? PatrolCode { get; set; }

    public long AreaId { get; set; }

    public string? AreaName { get; set; }

    public long SectorId { get; set; }

    public string? SectorName { get; set; }

    public string? PatrolPlateNumber { get; set; }

    public int? PatrolCategoryId { get; set; }

    public long OrganizationId { get; set; }
}
