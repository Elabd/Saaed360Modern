using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsEmployeeTypeDim
{
    public int EventEmployeeTypeId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public virtual ICollection<EventsPerson> EventsPeople { get; set; } = new List<EventsPerson>();
}
