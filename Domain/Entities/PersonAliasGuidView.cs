using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonAliasGuidView
{
    public Guid PersonAliasGuid { get; set; }

    public Guid PersonGuid { get; set; }

    public string? PersonNameCategoryCode { get; set; }

    public bool? IsPrimary { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Moniker { get; set; }

    public string? Suffix { get; set; }

    public string? Prefix { get; set; }

    public string FullName { get; set; } = null!;

    public string LastNameFirst { get; set; } = null!;

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
