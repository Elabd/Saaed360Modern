using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonRelationshipTypeDim
{
    public int PersonRelationshipTypeId { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<PersonRelationship> PersonRelationships { get; set; } = new List<PersonRelationship>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
