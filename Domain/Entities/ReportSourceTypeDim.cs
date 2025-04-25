using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportSourceTypeDim
{
    public int Id { get; set; }

    public string? SourceTypeCode { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
