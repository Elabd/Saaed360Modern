using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VwUserBasicInfo
{
    public long PersonId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string UserName { get; set; } = null!;

    public Guid UserId { get; set; }

    public int? PersonCategoryId { get; set; }

    public long ContactId { get; set; }

    public string ContactInformation { get; set; } = null!;
}
