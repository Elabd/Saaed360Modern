using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RequestServiceGuidView
{
    public Guid RequestServiceGuid { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? RequestServiceCategoryCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}

