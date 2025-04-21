using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GeoCensusTractDim
{
    public int GeoCensusTractId { get; set; }

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string StateName { get; set; } = null!;

    public string CountyName { get; set; } = null!;

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
