using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ObjectionCustomerDocumentTypeDim
{
    public int ObjectionCustomerDocumentTypeId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public virtual ICollection<EsAttachment> EsAttachments { get; set; } = new List<EsAttachment>();
}
