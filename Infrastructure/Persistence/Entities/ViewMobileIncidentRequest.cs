using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewMobileIncidentRequest
{
    public long ActivityId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public string? FirstName { get; set; }

    public string? Name { get; set; }

    public long? AreaId { get; set; }
}
