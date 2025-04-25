using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventsPersonJobTypeDim
{
    public int EventsPersonJobTypeId { get; set; }

    public string DescriptionAr { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;

    public virtual ICollection<EventsPerson> EventsPeople { get; set; } = new List<EventsPerson>();
}
