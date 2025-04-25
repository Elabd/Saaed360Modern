using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonClothingGuidView
{
    public Guid PersonClothingGuid { get; set; }

    public string PersonClothingDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? PersonClothingCategoryCode { get; set; }

    public string? PersonClothingColorCode { get; set; }

    public string? PersonClothingStyleCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
