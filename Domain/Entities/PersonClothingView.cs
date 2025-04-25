using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonClothingView
{
    public long PersonClothingId { get; set; }

    public string PersonClothingDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public string? PersonClothingCategoryCode { get; set; }

    public string? PersonClothingCategoryDescription { get; set; }

    public string? PersonClothingColorCode { get; set; }

    public string? PersonClothingColorDescription { get; set; }

    public string? PersonClothingStyleCode { get; set; }

    public string? PersonClothingStyleDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
