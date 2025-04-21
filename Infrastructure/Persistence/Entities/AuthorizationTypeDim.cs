using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AuthorizationTypeDim
{
    public int AuthorizationTypeId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? NiemtypeName { get; set; }

    public string? Niem { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Audit> Audits { get; set; } = new List<Audit>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<Search> Searches { get; set; } = new List<Search>();
}
