using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonRelationshipGuidView
{
    public Guid PersonRelationshipGuid { get; set; }

    public string PersonRelationshipDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid PersonRelatedGuid { get; set; }

    public string? PersonRelationshipTypeCode { get; set; }

    public string? RelationshipDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
