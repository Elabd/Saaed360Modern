using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistAppConfig
{
    public Guid AppConfigId { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public int MinutesToCloseNotPaidRequests { get; set; }

    public int MinutesToResendRatingNotification { get; set; }
}
