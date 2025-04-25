using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistRequestFee
{
    public Guid RequestFeesId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? RequestId { get; set; }

    public Guid? FeesTypeId { get; set; }

    public decimal Amount { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistRequestFeesTypeDim? FeesType { get; set; }

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual RoadAssistRequest? Request { get; set; }
}
