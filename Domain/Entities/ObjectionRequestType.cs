using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ObjectionRequestType
{
    public int RequestTypeId { get; set; }

    public string ArabicDescription { get; set; } = null!;

    public string EnglishDescription { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual ICollection<EsService> EsServices { get; set; } = new List<EsService>();
}
