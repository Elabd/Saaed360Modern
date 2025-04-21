using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ChangePasswordSession
{
    public Guid Id { get; set; }

    public Guid ClientApplicationId { get; set; }

    public string Email { get; set; } = null!;

    public string ReturnUrl { get; set; } = null!;

    public bool IsCompleted { get; set; }

    public DateTime CreationDate { get; set; }

    public int AttemptsCount { get; set; }

    public DateTime? LastAttemptDate { get; set; }

    public virtual ClientApplication ClientApplication { get; set; } = null!;
}
