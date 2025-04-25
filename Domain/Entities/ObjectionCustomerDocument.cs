using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ObjectionCustomerDocument
{
    public long Id { get; set; }

    public long? ObjectionId { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentExtension { get; set; }

    public string? ClientName { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ObjectionCustomerDocumentTypeId { get; set; }

    public string? OriginalName { get; set; }

    public virtual Objection? Objection { get; set; }
}
