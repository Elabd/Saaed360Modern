using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TrafficViolationTypeDim
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string DescriptionAr { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<TrafficViolation> TrafficViolations { get; set; } = new List<TrafficViolation>();
}
