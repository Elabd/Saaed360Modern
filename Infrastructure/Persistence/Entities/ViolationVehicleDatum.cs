using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViolationVehicleDatum
{
    public long ViolationVehicleDataId { get; set; }

    public int? PlateSourceId { get; set; }

    public int? PlateKindId { get; set; }

    public int? PlateColorId { get; set; }

    public int? PlateCategoryId { get; set; }

    public string? PlateNumber { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ItemRegistrationPlateCategoryDim? PlateCategory { get; set; }

    public virtual ItemRegistrationPlateColorDim? PlateColor { get; set; }

    public virtual ItemRegistrationPlateKindDim? PlateKind { get; set; }

    public virtual PlateSourceDim? PlateSource { get; set; }

    public virtual ICollection<Violation> Violations { get; set; } = new List<Violation>();
}
