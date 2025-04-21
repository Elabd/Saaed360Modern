using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PlateSourceToPlateTypeMap
{
    public long Id { get; set; }

    public int? PlateSourceId { get; set; }

    public int? ItemRegistrationPlateCategoryId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public virtual ItemRegistrationPlateCategoryDim? ItemRegistrationPlateCategory { get; set; }

    public virtual PlateSourceDim? PlateSource { get; set; }
}

