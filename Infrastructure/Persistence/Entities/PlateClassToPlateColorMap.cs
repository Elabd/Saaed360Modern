using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PlateClassToPlateColorMap
{
    public long Id { get; set; }

    public int? ItemRegistrationPlateKindId { get; set; }

    public int? ItemRegistrationPlateColorId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public virtual ItemRegistrationPlateColorDim? ItemRegistrationPlateColor { get; set; }

    public virtual ItemRegistrationPlateKindDim? ItemRegistrationPlateKind { get; set; }
}

