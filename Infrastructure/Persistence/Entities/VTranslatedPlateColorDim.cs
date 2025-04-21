using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VTranslatedPlateColorDim
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? DescriptionAr { get; set; }

    public int? PlateSourceId { get; set; }

    public string? DescriptionEn { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public bool? IsDeleted { get; set; }
}

