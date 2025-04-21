using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MissingPersonCategoryDim
{
    public int MissingPersonCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<MissingPerson> MissingPeople { get; set; } = new List<MissingPerson>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
