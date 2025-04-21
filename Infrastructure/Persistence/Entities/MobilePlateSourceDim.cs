using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobilePlateSourceDim
{
    public int PlateSourceId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool InEmirates { get; set; }
}

