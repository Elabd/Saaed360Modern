using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RequestOffenseGuidView
{
    public Guid RequestOffenseGuid { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? OffenseCodeCode { get; set; }

    public string? RequestOffenseCategoryCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
