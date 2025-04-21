using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonIntoxicationGuidView
{
    public Guid PersonIntoxicationGuid { get; set; }

    public string PersonIntoxicationDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? IntoxicationIntoxicantCategoryCode { get; set; }

    public string? IntoxicationLevelCode { get; set; }

    public DateTime? EntryDateTime { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
