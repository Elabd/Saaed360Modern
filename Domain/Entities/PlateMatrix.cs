using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PlateMatrix
{
    public long PlateMatrixId { get; set; }

    public int? PlateColorId { get; set; }

    public int? PlateClassId { get; set; }

    public int? PlateTypeId { get; set; }

    public int? PlateSourceId { get; set; }

    public bool? IsActive { get; set; }

    public virtual ItemRegistrationPlateKindDim? PlateClass { get; set; }

    public virtual ItemRegistrationPlateColorDim? PlateColor { get; set; }

    public virtual PlateSourceDim? PlateSource { get; set; }

    public virtual ItemRegistrationPlateCategoryDim? PlateType { get; set; }
}

