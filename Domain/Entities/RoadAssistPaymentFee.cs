using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistPaymentFee
{
    public Guid PaymentFeesId { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime EffectiveStartDate { get; set; }

    public DateTime? EffectiveEndDate { get; set; }

    public decimal PaymentFeesPercentage { get; set; }

    public virtual RoadAssistUser? CreatedByUser { get; set; }

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }
}
