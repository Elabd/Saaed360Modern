using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VTeattendance
{
    public long LoginActivityId { get; set; }

    public DateTime? LoginDate { get; set; }

    public string? FirstName { get; set; }

    public string UserName { get; set; } = null!;

    public long PersonId { get; set; }

    public long ItemId { get; set; }

    public string? PatrolName { get; set; }

    public long SectorId { get; set; }

    public string? Sector { get; set; }

    public long AreaId { get; set; }

    public string? AreaDescription { get; set; }

    public string? Emriate { get; set; }

    public long? LogoutActivityId { get; set; }

    public DateTime? LogoutDate { get; set; }

    public int? ActivityCategoryId { get; set; }
}
