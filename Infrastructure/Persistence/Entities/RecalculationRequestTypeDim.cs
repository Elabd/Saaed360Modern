using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RecalculationRequestTypeDim
{
    public int RecalculationRequestTypeId { get; set; }

    public string? ArabicDescription { get; set; }

    public string? EnglishDescription { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<RecalculationRequest> RecalculationRequests { get; set; } = new List<RecalculationRequest>();
}
