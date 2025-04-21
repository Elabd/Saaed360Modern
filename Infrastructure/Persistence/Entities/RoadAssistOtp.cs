using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistOtp
{
    public Guid Id { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public string Otp { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public bool IsUsed { get; set; }

    public bool IsDeleted { get; set; }
}
