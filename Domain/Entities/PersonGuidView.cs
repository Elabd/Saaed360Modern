using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonGuidView
{
    public Guid PersonGuid { get; set; }

    public string Description { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public string? PersonStatusCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Moniker { get; set; }

    public string? Suffix { get; set; }

    public string? Prefix { get; set; }

    public int? PersonCategoryId { get; set; }

    public string? RowStatusCode { get; set; }
}
