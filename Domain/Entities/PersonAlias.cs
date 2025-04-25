using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonAlias
{
    public long PersonAliasId { get; set; }

    public Guid PersonAliasGuid { get; set; }

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public int? PersonNameCategoryId { get; set; }

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

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonNameCategoryDim? PersonNameCategory { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
