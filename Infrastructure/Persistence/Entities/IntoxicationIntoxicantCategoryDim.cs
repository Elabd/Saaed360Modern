using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IntoxicationIntoxicantCategoryDim
{
    public int IntoxicationIntoxicantCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonIntoxication> PersonIntoxications { get; set; } = new List<PersonIntoxication>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
