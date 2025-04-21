using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GetActiveDirectoryPersonsFullDetail
{
    public long PersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? Email { get; set; }

    public string UserName { get; set; } = null!;

    public Guid UserId { get; set; }
}
