using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RecalculationRequestAttachment
{
    public long RecalculationRequestAttachmentId { get; set; }

    public string? AttachmentName { get; set; }

    public string? AttachmentPath { get; set; }

    public int? AttachmentType { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public long? Createdby { get; set; }

    public bool? IsDeleted { get; set; }

    public long? RecalculationRequestId { get; set; }

    public virtual Person? CreatedbyNavigation { get; set; }

    public virtual RecalculationRequest? RecalculationRequest { get; set; }
}
