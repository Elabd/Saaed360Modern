using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonRelationship
{
    public long PersonRelationshipId { get; set; }

    public Guid PersonRelationshipGuid { get; set; }

    public string PersonRelationshipDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long PersonRelatedId { get; set; }

    public Guid PersonRelatedGuid { get; set; }

    public long? SourceId { get; set; }

    public int? PersonRelationshipTypeId { get; set; }

    public string? RelationshipDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual Person PersonRelated { get; set; } = null!;

    public virtual PersonRelationshipTypeDim? PersonRelationshipType { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source? Source { get; set; }
}
