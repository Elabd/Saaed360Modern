using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestServiceTypeDim
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<ReportRequest> ReportRequests { get; set; } = new List<ReportRequest>();
}

