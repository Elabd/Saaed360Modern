using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViolationAttachement
{
    public long Id { get; set; }

    public long? ViolationId { get; set; }

    public string? AttachementName { get; set; }

    public string? AttachementPath { get; set; }

    public bool? IsVideo { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Violation? Violation { get; set; }
}
