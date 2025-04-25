using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestServiceView
{
    public long RequestServiceId { get; set; }

    public long ActivityId { get; set; }

    public string? RequestServiceCategoryCode { get; set; }

    public string? RequestServiceCategoryDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}

