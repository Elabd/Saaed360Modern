using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class User
{
    public long PersonId { get; set; }

    public long PrimaryPersonAliasId { get; set; }

    public int SourceDirectoryCategoryId { get; set; }

    public string? DirectoryDomain { get; set; }

    public Guid PrimaryPersonAliasGuid { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonAlias PrimaryPersonAlias { get; set; } = null!;

    public virtual SourceDirectoryCategoryDim SourceDirectoryCategory { get; set; } = null!;
}
