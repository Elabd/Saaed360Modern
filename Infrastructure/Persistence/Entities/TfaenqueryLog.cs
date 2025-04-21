using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TfaenqueryLog
{
    public long Id { get; set; }

    public long PlateColorId { get; set; }

    public long PlateTypeId { get; set; }

    public long PlateKindId { get; set; }

    public long PlateSourceId { get; set; }

    public string PlateNo { get; set; } = null!;

    public DateTime EnqueryDateTime { get; set; }

    public bool IsFound { get; set; }

    public string? ErrorMsg { get; set; }

    public string? OwnerAddress { get; set; }

    public string? OwnerName { get; set; }

    public long? VehicleCategoryId { get; set; }

    public string? VehicleChassisNumber { get; set; }
}
