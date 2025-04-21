using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class HighLowDim
{
    public int HighLowId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Bolo> Bolos { get; set; } = new List<Bolo>();

    public virtual ICollection<Comment> CommentImportanceHighLows { get; set; } = new List<Comment>();

    public virtual ICollection<Comment> CommentPriorityHighLows { get; set; } = new List<Comment>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<TipLead> TipLeads { get; set; } = new List<TipLead>();
}
