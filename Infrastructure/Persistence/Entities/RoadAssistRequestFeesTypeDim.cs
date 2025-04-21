using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistRequestFeesTypeDim
{
    public Guid FeesTypeId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string Code { get; set; } = null!;

    public string FeesTypeNameEn { get; set; } = null!;

    public string FeesTypeNameAr { get; set; } = null!;

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual ICollection<RoadAssistRequestFee> RoadAssistRequestFees { get; set; } = new List<RoadAssistRequestFee>();
}
