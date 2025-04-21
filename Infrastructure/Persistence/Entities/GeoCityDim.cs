using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GeoCityDim
{
    public int GeoCityId { get; set; }

    public string Code { get; set; } = null!;

    public string? CityName { get; set; }

    public string? CityCode { get; set; }

    public string? StateName { get; set; }

    public string? CountyName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
