using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GeoZipDim
{
    public int GeoZipId { get; set; }

    public string Code { get; set; } = null!;

    public string? ZipCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
