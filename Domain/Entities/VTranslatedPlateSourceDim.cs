using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VTranslatedPlateSourceDim
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public bool? IsDeleted { get; set; }
}

