using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RecalculationStatusDim
{
    public int RecalculationStatusId { get; set; }

    public string? ArabicDescription { get; set; }

    public string? EnglishDescription { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<RecalculationRequest> RecalculationRequests { get; set; } = new List<RecalculationRequest>();
}
