using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonTooth
{
    public long PersonToothId { get; set; }

    public Guid PersonToothGuid { get; set; }

    public string PersonToothDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public int? DentalToothPositionId { get; set; }

    public int? DentalCharacteristicRestorationId { get; set; }

    public int? DentalStatusId { get; set; }

    public int? DentalCharacteristicId { get; set; }

    public DateOnly? DentalDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual DentalCharacteristicDim? DentalCharacteristic { get; set; }

    public virtual DentalCharacteristicRestorationDim? DentalCharacteristicRestoration { get; set; }

    public virtual DentalStatusDim? DentalStatus { get; set; }

    public virtual DentalToothPositionDim? DentalToothPosition { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
