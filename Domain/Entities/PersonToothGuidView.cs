using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonToothGuidView
{
    public Guid PersonToothGuid { get; set; }

    public string PersonToothDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? DentalToothPositionCode { get; set; }

    public string? DentalCharacteristicRestorationCode { get; set; }

    public string? DentalStatusCode { get; set; }

    public string? DentalCharacteristicCode { get; set; }

    public DateOnly? DentalDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
