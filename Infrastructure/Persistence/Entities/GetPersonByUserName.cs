using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GetPersonByUserName
{
    public Guid UserId { get; set; }

    public string UserName { get; set; } = null!;

    public long PersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public int? PersonStatusId { get; set; }

    public string? OriginalIdent { get; set; }

    public string Description { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? PersonCategory { get; set; }
}
