using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MissingPersonCircumstanceDim
{
    public int MissingPersonCircumstanceId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<MissingPerson> MissingPeople { get; set; } = new List<MissingPerson>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
