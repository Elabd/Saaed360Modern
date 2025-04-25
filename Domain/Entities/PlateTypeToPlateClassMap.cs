using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PlateTypeToPlateClassMap
{
    public long Id { get; set; }

    public int? ItemRegistrationPlateCategoryId { get; set; }

    public int? ItemRegistrationPlateKindId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public virtual ItemRegistrationPlateCategoryDim? ItemRegistrationPlateCategory { get; set; }

    public virtual ItemRegistrationPlateKindDim? ItemRegistrationPlateKind { get; set; }
}

