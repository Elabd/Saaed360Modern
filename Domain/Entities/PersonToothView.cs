using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonToothView
{
    public long PersonToothId { get; set; }

    public string PersonToothDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public string? DentalToothPositionCode { get; set; }

    public string? DentalToothPositionDescription { get; set; }

    public string? DentalCharacteristicRestorationCode { get; set; }

    public string? DentalCharacteristicRestorationDescription { get; set; }

    public string? DentalStatusCode { get; set; }

    public string? DentalStatusDescription { get; set; }

    public string? DentalCharacteristicCode { get; set; }

    public string? DentalCharacteristicDescription { get; set; }

    public DateOnly? DentalDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
