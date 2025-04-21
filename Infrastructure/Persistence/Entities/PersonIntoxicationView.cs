using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonIntoxicationView
{
    public long PersonIntoxicationId { get; set; }

    public string PersonIntoxicationDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public string? IntoxicationIntoxicantCategoryCode { get; set; }

    public string? IntoxicationIntoxicantCategoryDescription { get; set; }

    public string? IntoxicationLevelCode { get; set; }

    public string? IntoxicationLevelDescription { get; set; }

    public DateTime? EntryDateTime { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
