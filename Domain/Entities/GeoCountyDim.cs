using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GeoCountyDim
{
    public int GeoCountyId { get; set; }

    public string Code { get; set; } = null!;

    public string? CountyName { get; set; }

    public string? CountyCode { get; set; }

    public string? StateName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
