using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EscortAttachment
{
    public int EscortAttachmentId { get; set; }

    public string? Name { get; set; }

    public string? Path { get; set; }

    public long? EscortId { get; set; }

    public int? EscortAttachmentTypeId { get; set; }

    public virtual Escort? Escort { get; set; }

    public virtual EscortAttachmentTypeDim? EscortAttachmentType { get; set; }
}
