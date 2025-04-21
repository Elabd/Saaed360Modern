using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistIntegrationTokenLog
{
    public Guid Id { get; set; }

    public string Token { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public Guid UserId { get; set; }

    public Guid UserTypeId { get; set; }

    public virtual RoadAssistUser User { get; set; } = null!;

    public virtual RoadAssistUserType UserType { get; set; } = null!;
}
