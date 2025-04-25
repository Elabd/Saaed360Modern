using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LogoutToken
{
    public Guid Id { get; set; }

    public string? Token { get; set; }

    public Guid? UserId { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public DateTime CreationDate { get; set; }
}
