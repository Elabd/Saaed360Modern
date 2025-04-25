using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DisseminationMethodDim
{
    public int DisseminationMethodId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Dissemination> Disseminations { get; set; } = new List<Dissemination>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
