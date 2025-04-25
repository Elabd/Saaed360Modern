using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonNameCategoryDim
{
    public int PersonNameCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Nciccode { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonAlias> PersonAliases { get; set; } = new List<PersonAlias>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
