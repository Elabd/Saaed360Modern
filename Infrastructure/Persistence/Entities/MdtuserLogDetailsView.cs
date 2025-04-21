using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MdtuserLogDetailsView
{
    public long PersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? CheckoutCategoryId { get; set; }

    public int CheckinCategoryId { get; set; }

    public DateTime? CheckoutDate { get; set; }

    public DateTime? CheckoutTime { get; set; }

    public DateTime? CheckinDate { get; set; }

    public DateTime? CheckinTime { get; set; }

    public string? SectorName { get; set; }

    public string? AreaName { get; set; }

    public long PatrolId { get; set; }

    public string? PatrolPlateNumber { get; set; }

    public int? PatrolCategoryId { get; set; }

    public string? SerialIdentification { get; set; }
}
