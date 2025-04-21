using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RequestOffenseView
{
    public long RequestOffenseId { get; set; }

    public long ActivityId { get; set; }

    public string? OffenseCodeCode { get; set; }

    public string? OffenseCodeDescription { get; set; }

    public string? RequestOffenseCategoryCode { get; set; }

    public string? RequestOffenseCategoryDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
