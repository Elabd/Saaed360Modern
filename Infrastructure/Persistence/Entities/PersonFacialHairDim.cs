using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonFacialHairDim
{
    public int PersonFacialHairId { get; set; }

    public int? PersonFacialHairColorId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual PersonHairColorDim? PersonFacialHairColor { get; set; }

    public virtual ICollection<PersonPhysicalDetail> PersonPhysicalDetails { get; set; } = new List<PersonPhysicalDetail>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
