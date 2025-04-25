using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ObjectionExemptionRequestType
{
    public int ExemptionRequestTypeId { get; set; }

    public string ArabicDescription { get; set; } = null!;

    public string EnglishDescription { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
