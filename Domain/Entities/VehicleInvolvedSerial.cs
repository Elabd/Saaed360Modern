using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VehicleInvolvedSerial
{
    public int VehicleSerialId { get; set; }

    public int ReportId { get; set; }

    public int VehicleDataId { get; set; }

    public long VehicleSerial { get; set; }

    public int? VehicleRoleId { get; set; }

    public bool? AccidentInvolved { get; set; }

    public bool? AccidentDamagedPart { get; set; }

    public bool? AccidentCause { get; set; }

    public bool? DamagedGovProperty { get; set; }
}
