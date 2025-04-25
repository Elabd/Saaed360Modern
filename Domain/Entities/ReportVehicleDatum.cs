using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportVehicleDatum
{
    public int ReportVehicleDataId { get; set; }

    public int? VehicleDataId { get; set; }

    public int? ReportId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    public virtual Report? Report { get; set; }

    public virtual VehicleDatum? VehicleData { get; set; }
}
