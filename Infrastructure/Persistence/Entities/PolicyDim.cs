using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PolicyDim
{
    public int PolicyId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<TipLead> TipLeads { get; set; } = new List<TipLead>();
}
