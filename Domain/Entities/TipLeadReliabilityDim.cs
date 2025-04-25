using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TipLeadReliabilityDim
{
    public int TipLeadReliablityId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<TipLead> TipLeads { get; set; } = new List<TipLead>();
}
