using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PlateSourceDim1
{
    public int PlateSourceId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool InEmirates { get; set; }
}

