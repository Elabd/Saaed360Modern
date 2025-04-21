using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GeoStateDim
{
    public int GeoStateId { get; set; }

    public string Code { get; set; } = null!;

    public string? StateName { get; set; }

    public string? StateCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
