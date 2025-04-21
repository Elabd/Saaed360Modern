using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RequestCheckGuidView
{
    public Guid RequestCheckGuid { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? RequestCheckCategoryCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
