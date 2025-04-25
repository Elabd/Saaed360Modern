using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RepairRequestStatusPerGarageView
{
    public Guid? Id { get; set; }

    public long RepairRequestId { get; set; }

    public DateTime? CreationDate { get; set; }

    public int ReportId { get; set; }

    public int VehicleDataId { get; set; }

    public bool? IsDelayed { get; set; }

    public bool IsDeleted { get; set; }

    public long RequestEmirateId { get; set; }

    public long RequestAreaId { get; set; }

    public DateTime ExpectedDeliveryDate { get; set; }

    public long UserId { get; set; }

    public int GarageId { get; set; }

    public string GarageNameArabic { get; set; } = null!;

    public string GarageNameEnglishc { get; set; } = null!;

    public long GarageEmirateId { get; set; }

    public long GarageAreaId { get; set; }

    public int StatusId { get; set; }

    public string StatusArabic { get; set; } = null!;

    public string StatusEnglish { get; set; } = null!;

    public string StatusCode { get; set; } = null!;

    public double? Distance { get; set; }
}
