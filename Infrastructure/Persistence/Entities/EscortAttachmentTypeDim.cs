using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EscortAttachmentTypeDim
{
    public int EscortAttachmentTypeId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }

    public virtual ICollection<EscortAttachment> EscortAttachments { get; set; } = new List<EscortAttachment>();
}
