using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubjectDisciplinaryActionDim
{
    public int SubjectDisciplinaryActionId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
