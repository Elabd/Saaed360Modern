using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class QuestionCategoryDim
{
    public int QuestionCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
