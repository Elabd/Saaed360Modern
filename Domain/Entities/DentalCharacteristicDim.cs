using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DentalCharacteristicDim
{
    public int DentalCharacteristicId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonTooth> PersonTeeth { get; set; } = new List<PersonTooth>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
