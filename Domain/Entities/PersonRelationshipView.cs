using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonRelationshipView
{
    public long PersonRelationshipId { get; set; }

    public string PersonRelationshipDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long PersonRelatedId { get; set; }

    public string? PersonRelationshipTypeCode { get; set; }

    public string? PersonRelationshipTypeDescription { get; set; }

    public string? RelationshipDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
