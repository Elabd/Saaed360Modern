using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestCheckView
{
    public long RequestCheckId { get; set; }

    public long ActivityId { get; set; }

    public string? RequestCheckCategoryCode { get; set; }

    public string? RequestCheckCategoryDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
