using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AppVersion
{
    public long AppVersionId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public int DeviceType { get; set; }

    public string AppVersion1 { get; set; } = null!;

    public bool IsMandatory { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime EffectiveStartDate { get; set; }

    public DateTime? EffectiveEndDate { get; set; }
}
