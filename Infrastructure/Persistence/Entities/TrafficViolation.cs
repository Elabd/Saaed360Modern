using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TrafficViolation
{
    public long Id { get; set; }

    public int ReportId { get; set; }

    public int VehicleDataId { get; set; }

    public int TypeId { get; set; }

    public int StatusId { get; set; }

    public DateTime CreationDate { get; set; }

    public long CreatedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Person CreatedByNavigation { get; set; } = null!;

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Report Report { get; set; } = null!;

    public virtual TrafficViolationStatusDim Status { get; set; } = null!;

    public virtual ICollection<TrafficViolationRejectionReason> TrafficViolationRejectionReasons { get; set; } = new List<TrafficViolationRejectionReason>();

    public virtual ICollection<TrafficViolationStatusLog> TrafficViolationStatusLogs { get; set; } = new List<TrafficViolationStatusLog>();

    public virtual TrafficViolationTypeDim Type { get; set; } = null!;

    public virtual VehicleDatum VehicleData { get; set; } = null!;
}
