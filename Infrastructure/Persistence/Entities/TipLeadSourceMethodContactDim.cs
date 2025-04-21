using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TipLeadSourceMethodContactDim
{
    public int TipLeadSourceMethodContactId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<TipLead> TipLeads { get; set; } = new List<TipLead>();
}
