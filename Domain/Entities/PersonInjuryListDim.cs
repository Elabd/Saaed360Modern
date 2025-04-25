using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonInjuryListDim
{
    public int PersonInjuryListId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonInjury> PersonInjuries { get; set; } = new List<PersonInjury>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
