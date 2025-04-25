using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceCenterLookup
{
    public long ServiceCenterId { get; set; }

    public string? ServiceCenterName { get; set; }

    public long? AreaId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }
}

