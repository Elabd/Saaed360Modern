using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TrafficViolationStatusDim
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;

    public string DescriptionAr { get; set; } = null!;

    public string? PoliceDescriptionEn { get; set; }

    public string? PoliceDescriptionAr { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsPoliceStatus { get; set; }

    public virtual ICollection<TrafficViolationStatusLog> TrafficViolationStatusLogNewStatusNavigations { get; set; } = new List<TrafficViolationStatusLog>();

    public virtual ICollection<TrafficViolationStatusLog> TrafficViolationStatusLogOldStatusNavigations { get; set; } = new List<TrafficViolationStatusLog>();

    public virtual ICollection<TrafficViolation> TrafficViolations { get; set; } = new List<TrafficViolation>();
}
