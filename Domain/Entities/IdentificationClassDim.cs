using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IdentificationClassDim
{
    public int IdentificationClassId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonOtherIdentification> PersonOtherIdentifications { get; set; } = new List<PersonOtherIdentification>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
