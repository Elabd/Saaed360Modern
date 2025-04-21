using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EmploymentOccupationDim
{
    public int EmploymentOccupationId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonEmployment> PersonEmployments { get; set; } = new List<PersonEmployment>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
