using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CompanyAttachment
{
    public long CompanyAttachmentId { get; set; }

    public long? CompanyId { get; set; }

    public string? Name { get; set; }

    public string? Path { get; set; }

    public virtual Company? Company { get; set; }
}
