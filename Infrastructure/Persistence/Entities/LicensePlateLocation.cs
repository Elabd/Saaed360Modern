using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LicensePlateLocation
{
    public long ActivityId { get; set; }

    public int? LicensePlateCameraId { get; set; }

    public int? LicensePlateDirectionId { get; set; }

    public int? LicensePlateLaneId { get; set; }

    public int? LicensePlateViolationTypeId { get; set; }

    public int? LegalSpeedRate { get; set; }

    public int? RecordedSpeedRate { get; set; }

    public int? LegalSpeedLimitForCapture { get; set; }

    public bool? IsPhotoPresent { get; set; }

    public bool? IsVideoPresent { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual LicensePlateCameraDim? LicensePlateCamera { get; set; }

    public virtual LicensePlateDirectionDim? LicensePlateDirection { get; set; }

    public virtual LicensePlateLaneDim? LicensePlateLane { get; set; }

    public virtual LicensePlateViolationTypeDim? LicensePlateViolationType { get; set; }
}

