using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DocumentStatusDim
{
    public int DocumentStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
