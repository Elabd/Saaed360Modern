using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RspReportsVehicleDatum
{
    public long RspReportVehicleDataId { get; set; }

    public long? RspVehicleDataId { get; set; }

    public int? ReportId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public virtual Report? Report { get; set; }

    public virtual RspVehicleDatum? RspVehicleData { get; set; }
}
